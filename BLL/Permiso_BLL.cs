using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Permiso_BLL
    {
        private readonly Permiso_Mapper permisoDAL = new Permiso_Mapper();

        public List<Componente> ObtenerTodoElArbol()
        {
            var dtPermisos = permisoDAL.ListarPermisos();
            var dtRelaciones = permisoDAL.ListarTodasLasRelaciones();

            var listaComponentes = new Dictionary<int, Componente>();

            foreach (DataRow row in dtPermisos.Rows)
            {
                Componente c = MapRow(row);
                listaComponentes.Add(c.ID_Permiso, c);
            }

            foreach (DataRow row in dtRelaciones.Rows)
            {
                int idPadre = Convert.ToInt32(row["ID_Padre"]);
                int idHijo = Convert.ToInt32(row["ID_Hijo"]);

               
                if (listaComponentes.ContainsKey(idPadre) && listaComponentes.ContainsKey(idHijo))
                {
                    var padre = listaComponentes[idPadre];
                    var hijo = listaComponentes[idHijo];

                    
                    if (padre.EsFamilia)
                    {
                        padre.Agregar(hijo);
                    }
                }
            }

            
            return listaComponentes.Values.ToList();
        }

       
        public Usuario ObtenerUsuarioConPermisos(int idUsuario)
        {
            Usuario usuario = new Usuario { ID = idUsuario };
            var todos = ObtenerTodoElArbol(); 

           
            var dtAsignaciones = permisoDAL.ListarPermisosDeUsuario(idUsuario);

            foreach (DataRow row in dtAsignaciones.Rows)
            {
                int idPermiso = Convert.ToInt32(row["ID_Permiso"]);
                
                Componente c = todos.FirstOrDefault(x => x.ID_Permiso == idPermiso);
                if (c != null)
                {
                    usuario.Asignados.Add(c);
                }
            }
            return usuario;
        }

        public bool UsuarioTienePermiso(Usuario usuario, string nombrePermiso)
        {
            if (usuario.Asignados == null) return false;
            return usuario.Asignados.Any(c => c.Contiene(nombrePermiso));
        }

        

        public void GuardarComponente(Componente c, bool esFamilia)
        {
            
            char tipo = esFamilia ? 'F' : 'P';
            int id = permisoDAL.CrearPermiso(c.Nombre, c.Descripcion, tipo);
            c.ID_Permiso = id;
        }

        public bool AgregarHijo(Componente padre, Componente hijo)
        {
            if (!padre.EsFamilia)
            {
                throw new Exception("Error: No se pueden agregar hijos a una Patente (es una hoja).");
                return false;
            }

            if (padre.ID_Permiso == hijo.ID_Permiso)
            {
                throw new Exception("Error: No se puede agregar una familia dentro de sí misma.");
                return false;
            }

            if (padre.Contiene(hijo.Nombre))
            {
                throw new Exception($"Error: El permiso '{hijo.Nombre}' ya existe en la jerarquía de '{padre.Nombre}'.");
                return false;
            }

            if (hijo.EsFamilia)
            {
                
                if (hijo.Contiene(padre.Nombre))
                {
                    throw new Exception("Error Crítico: Se detectó un ciclo. No puedes agregar al padre dentro de su propio hijo.");
                    return false;
                }
            }

          
            permisoDAL.AgregarHijoFamilia(padre.ID_Permiso, hijo.ID_Permiso);
            
           
            padre.Agregar(hijo);
            return true;
        }

        public void QuitarHijo(Familia padre, Componente hijo)
        {
            permisoDAL.QuitarHijoFamilia(padre.ID_Permiso, hijo.ID_Permiso);
            padre.Quitar(hijo);
        }

     
        private Componente MapRow(DataRow row)
        {
            string tipo = row["tipo"] != DBNull.Value ? row["tipo"].ToString().Trim() : "";
            int id = Convert.ToInt32(row["ID_Permiso"]);
            string nombre = row["nombre"].ToString();
            string descripcion = row["descripcion"] == DBNull.Value ? "" : row["descripcion"].ToString();

            Componente c;
            if (tipo == "F") c = new Familia();
            else c = new Patente();

            c.ID_Permiso = id;
            c.Nombre = nombre;
            c.Descripcion = descripcion;

            return c;
        }

        public List<Componente> ObtenerAsignadosUsuario(int idUsuario)
        {
           
            Usuario usuario = ObtenerUsuarioConPermisos(idUsuario);

         
            return usuario.Asignados;
        }
    }
}



using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using Servicios;

namespace BLL
{
    public class Usuario_BLL
    {
        Acceso acceso = new Acceso();

        public Usuario_Mapper mapper = new Usuario_Mapper();
        private readonly Permiso_BLL permisosBll = new Permiso_BLL();
        private readonly Permiso_Mapper permiso_Mapper = new Permiso_Mapper();

        public bool Logueo(Usuario usuario)
        {
            try
            {
                
                if (SessionManager.GetInstance != null)
                {
                    throw new Exception("Ya hay una sesión iniciada");
                }

                Usuario usuarioValidado = mapper.ObtenerUsuarioPorCredenciales(usuario);

                if (usuarioValidado == null)
                {
                    throw new Exception("Credenciales incorrectas");
                }
                else
                {
                    usuarioValidado = permisosBll.ObtenerUsuarioConPermisos(usuarioValidado.ID);

                    
                    SessionManager.Login(usuarioValidado);

                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

       
        public bool TienePermiso(Usuario usuario, string permiso)
        {
            
            return permisosBll.UsuarioTienePermiso(usuario, permiso);
        }

        public DataTable ListarUsuarios()
        {
            return mapper.ListarUsuarios();
        }

        public List<Componente> ObtenerAsignadosEfectivos(int idUsuario)
        {
            
            return permisosBll.ObtenerAsignadosUsuario(idUsuario);
        }

        public DataTable ListarPermisosTodos()
        {
            return permiso_Mapper.ListarPermisos();
        }

        public void Asignar(int idUsuario, int idPermiso)
        {
            permiso_Mapper.AsignarPermisoUsuario(idUsuario, idPermiso);
        }

        public void Quitar(int idUsuario, int idPermiso)
        {
            permiso_Mapper.QuitarPermisoUsuario(idUsuario, idPermiso);
        }

        private bool BuscarPermisoRecursivo(Componente componente, string nombreBuscado)
        {
            if (componente.Nombre.Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase))
                return true;

            if (componente.EsFamilia)
            {
                foreach (Componente hijo in componente.Hijos)
                {
                    if (BuscarPermisoRecursivo(hijo, nombreBuscado))
                        return true;
                }
            }
            return false;
        }
    }  
}

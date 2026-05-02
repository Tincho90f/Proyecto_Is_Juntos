using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Permiso_Mapper
    {
        private readonly Acceso acceso = new Acceso();

        public DataTable ListarPermisos()
        {
            acceso.AbrirConexion();
            DataTable dt = acceso.LeerBase("LISTAR_PERMISOS");
            acceso.CerrarConexion();
            return dt;
        }

        public DataTable ListarHijosDe(int idPadre)
        {
            acceso.AbrirConexion();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.Crear_Parametro("@ID_Padre", idPadre)
            };
            DataTable dt = acceso.LeerBase("LISTAR_HIJOS_DE", parametros);
            acceso.CerrarConexion();
            return dt;
        }

        public DataTable ListarPermisosDeUsuario(int idUsuario)
        {
            acceso.AbrirConexion();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.Crear_Parametro("@ID_Usuario", idUsuario)
            };
            DataTable dt = acceso.LeerBase("LISTAR_PERMISOS_DE_USUARIO", parametros);
            acceso.CerrarConexion();
            return dt;
        }

        public DataTable ListarTodasLasRelaciones()
        {
            acceso.AbrirConexion();
 
            DataTable dt = acceso.LeerBase("LISTAR_PERMISO_PERMISO");
            acceso.CerrarConexion();
            return dt;
        }

        public int CrearPermiso(string nombre, string descripcion, char tipo)
        {
            acceso.AbrirConexion();

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.Crear_Parametro("@nombre", nombre),
                acceso.Crear_Parametro("@descripcion", descripcion),
                acceso.Crear_Parametro("@tipo", tipo.ToString())
            };

            object resultado = acceso.LeerEscalar("CREAR_PERMISO", parametros);
            acceso.CerrarConexion();

            return Convert.ToInt32(resultado);
        }

        public void AgregarHijoFamilia(int idPadre, int idHijo)
        {
            acceso.AbrirConexion();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.Crear_Parametro("@ID_Padre", idPadre),
                acceso.Crear_Parametro("@ID_Hijo", idHijo)
            };
            acceso.EscribirBase("AGREGAR_HIJO_A_FAMILIA", parametros);
            acceso.CerrarConexion();
        }

        public void QuitarHijoFamilia(int idPadre, int idHijo)
        {
            acceso.AbrirConexion();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.Crear_Parametro("@ID_Padre", idPadre),
                acceso.Crear_Parametro("@ID_Hijo", idHijo)
            };
            acceso.EscribirBase("QUITAR_HIJO_DE_FAMILIA", parametros);
            acceso.CerrarConexion();
        }

        public void AsignarPermisoUsuario(int idUsuario, int idPermiso)
        {
            acceso.AbrirConexion();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.Crear_Parametro("@ID_Usuario", idUsuario),
                acceso.Crear_Parametro("@ID_Permiso", idPermiso)
            };
            acceso.EscribirBase("ASIGNAR_PERMISO_A_USUARIO", parametros);
            acceso.CerrarConexion();
        }

        public void QuitarPermisoUsuario(int idUsuario, int idPermiso)
        {
            acceso.AbrirConexion();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.Crear_Parametro("@ID_Usuario", idUsuario),
                acceso.Crear_Parametro("@ID_Permiso", idPermiso)
            };
            acceso.EscribirBase("QUITAR_PERMISO_A_USUARIO", parametros);
            acceso.CerrarConexion();
        }

        public DataTable ListarFamiliasRaiz()
        {
            acceso.AbrirConexion();
            DataTable dt = acceso.LeerBase("LISTAR_FAMILIAS_RAIZ");
            acceso.CerrarConexion();
            return dt;
        }
    }
}

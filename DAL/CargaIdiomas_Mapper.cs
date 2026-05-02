using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class CargaIdiomas_Mapper
    {
        private readonly Acceso acceso = new Acceso();

        public DataTable Listar_Etiquetas_Con_Traduccion(int idIdioma)
        {
            acceso.AbrirConexion();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.Crear_Parametro("@ID_Idioma", idIdioma));
            DataTable tabla = acceso.LeerBase("LISTAR_ETIQUETAS_CON_TRADUCCION", parametros);
            acceso.CerrarConexion();
            return tabla;
        }

        public int Crear_Idioma(string nombre)
        {
            acceso.AbrirConexion();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.Crear_Parametro("@nombre", nombre));

            int idnuevo = Convert.ToInt32(acceso.LeerEscalar("CREAR_IDIOMA", parametros)); 
            acceso.CerrarConexion();
            return idnuevo;
        }

        public int Guardar_Traduccion(int idIdioma, int idEtiqueta, string texto)
        {
            acceso.AbrirConexion();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.Crear_Parametro("@ID_Idioma", idIdioma));
            parametros.Add(acceso.Crear_Parametro("@ID_Etiqueta", idEtiqueta));
            parametros.Add(acceso.Crear_Parametro("@texto", texto));
            
            int filas = acceso.EscribirBase("GUARDAR_TRADUCCION", parametros); 
            acceso.CerrarConexion();
            return filas;
        }


    }
}
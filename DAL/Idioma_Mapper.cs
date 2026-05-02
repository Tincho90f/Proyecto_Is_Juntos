using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Idioma_Mapper
    {
        Acceso acceso = new Acceso();

        public List<Idioma> Listar_Idiomas()
        {
            acceso.AbrirConexion();
            DataTable tabla = acceso.LeerBase("Listar_Idiomas");
            acceso.CerrarConexion();

            List<Idioma> idiomas = new List<Idioma>();
            foreach (DataRow fila in tabla.Rows)
            {
                idiomas.Add(new Idioma
                {
                    Id_Idioma = Convert.ToInt32(fila["ID_Idioma"]),
                    Nombre = fila["nombre"].ToString()
                });
            }
            return idiomas;
        }

        public Idioma Obtener_Traducciones(int idIdioma)
        {
            acceso.AbrirConexion();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros = new List<SqlParameter>{
            acceso.Crear_Parametro("@ID_Idioma", idIdioma)};

            DataTable tabla = acceso.LeerBase("Listar_Traducciones_Por_Idioma", parametros);
            acceso.CerrarConexion();

            Idioma idioma = new Idioma ();
            idioma.Id_Idioma = idIdioma;
            foreach (DataRow fila in tabla.Rows)
            {
                idioma.Traducciones.Add(new Traduccion
                {
                    Etiqueta = new Etiqueta
                    {
                        // si SP devuelve también el ID_Etiqueta, mapealo acá
                        Nombre_Etiqueta = fila["nombre_etiqueta"].ToString()
                    },
                    Texto = fila["texto"].ToString()
                });
            }
            return idioma;
        }
    }
}
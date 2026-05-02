using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class CargaIdiomas_BLL
    {
        CargaIdiomas_Mapper cargaidiomas_mapper = new CargaIdiomas_Mapper();
        Idioma_Mapper idioma_mapper = new Idioma_Mapper(); // se reutiliza el mapper del Observer

        // Para el botón "Cargar": llena el DGV
        public DataTable CargarGrid(int idIdioma)
        {
            return cargaidiomas_mapper.Listar_Etiquetas_Con_Traduccion(idIdioma);
        }

        // Guardar cambios de un idioma existente
        public void GuardarCambiosIdiomaExistente(int idIdioma, DataTable grid)
        {
            foreach (DataRow row in grid.Rows)
            {
                int idEtiqueta = Convert.ToInt32(row["ID_Etiqueta"]);
                string texto;
                if (row["texto"] == DBNull.Value)
                {
                    texto = string.Empty;
                }
                else
                {
                    texto = row["texto"].ToString();
                }
                cargaidiomas_mapper.Guardar_Traduccion(idIdioma, idEtiqueta, texto);
            }
        }

        // Crear idioma nuevo y guardar
        public int CrearIdiomaYGuardar(string nombreNuevoIdioma, DataTable grid)
        {
            int idNuevo = cargaidiomas_mapper.Crear_Idioma(nombreNuevoIdioma);

            foreach (DataRow row in grid.Rows)
            {
                int idEtiqueta = Convert.ToInt32(row["ID_Etiqueta"]);
                string nombreEtiqueta = row["nombre_etiqueta"].ToString();
                string texto;
                if (row["texto"] == DBNull.Value)
                {
                    texto = null;
                }
                else
                {
                    texto = row["texto"].ToString();
                }

                if (string.IsNullOrWhiteSpace(texto))
                {
                    texto = "[" + nombreEtiqueta + "]"; // traducción provisoria
                }

                cargaidiomas_mapper.Guardar_Traduccion(idNuevo, idEtiqueta, texto);
            }

            return idNuevo;
        }


        public List<Idioma> Consultar_Idiomas()
        {
            return idioma_mapper.Listar_Idiomas();
        }
        
    }
}

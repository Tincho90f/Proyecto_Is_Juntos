using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BLL
{
    public class Bitacora_BLL
    {
        Bitacora_Mapper Bitacora_Mapper = new Bitacora_Mapper();
        Bitacora bitacora = new Bitacora();

        public void Registrar_Operacion(Usuario usuario_operacion, int num_operacion)
        {
            Operacion operacion = new Operacion();

            operacion.Usuario= usuario_operacion;
            operacion.Num_Tipo_Operacion = num_operacion;
            operacion.Fecha_Operacion= DateTime.Now;

            if (Bitacora_Mapper.Cargar_Operacion(operacion)==0)
            {
                MessageBox.Show("Error Carga Bitacora");
            }
        }

        public Bitacora Consultar_Operacion()
        {
           
            DataTable tabla = Bitacora_Mapper.Listar_Operaciones_Bitacora();
            bitacora.operaciones_bitacora.Clear();

            foreach (DataRow fila in tabla.Rows)
            {
                Operacion operacion = new Operacion();

                operacion.Usuario = new Usuario();

                operacion.ID_Operacion = Convert.ToInt32(fila["ID_Operacion"]);
                operacion.Usuario.Nombre = fila["usuario_nombre"].ToString();
                operacion.Tipo_Operacion = (TiposDeOperacion)Convert.ToInt32(fila["num_tipo_operacion"]);
                operacion.Fecha_Operacion = Convert.ToDateTime(fila["fecha_operacion"]);

                bitacora.operaciones_bitacora.Add(operacion);
            }
            return bitacora;
        }
    }
}
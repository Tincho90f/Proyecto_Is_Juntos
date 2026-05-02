using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
using BE;

namespace DAL
{
    public class Bitacora_Mapper
    {
        Acceso acceso = new Acceso();

        public int Cargar_Operacion(Operacion nueva_operacion)
        {
            try
            {
                acceso.AbrirConexion();
                string NombreSP = "CargarOperacion";
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(acceso.Crear_Parametro("@ID_Usuario", nueva_operacion.Usuario.ID));
                parameters.Add(acceso.Crear_Parametro("@num_tipo_operacion",nueva_operacion.Num_Tipo_Operacion));
                parameters.Add(acceso.Crear_Parametro("@fecha_operacion", nueva_operacion.Fecha_Operacion));
                int filas = acceso.EscribirBase(NombreSP, parameters);
                acceso.CerrarConexion();
                return filas;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable Listar_Operaciones_Bitacora()
        {
            try
            {
                string NombreSP = "ListarOperaciones";
                acceso.AbrirConexion();

                DataTable tabla = new DataTable();
                tabla = acceso.LeerBase(NombreSP);

                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
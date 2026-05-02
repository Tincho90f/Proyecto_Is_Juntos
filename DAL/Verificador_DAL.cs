using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using BE;
using Servicios;

namespace DAL
{
    public class Verificador_DAL
    {
        Acceso acceso = new Acceso();

        public void GuardarDVV(string nombreTabla, string dvvHex)
        {
            acceso.AbrirConexion();
            List<SqlParameter> ps = new List<SqlParameter>
            {
                acceso.Crear_Parametro("@tabla", nombreTabla),
                acceso.Crear_Parametro("@dvv", dvvHex ?? string.Empty)
            };
            acceso.EscribirBase("GUARDAR_DVV", ps);
            acceso.CerrarConexion();
        }

        public string ObtenerDVV(string nombreTabla)
        {
            acceso.AbrirConexion();
            List<SqlParameter> ps = new List<SqlParameter> { acceso.Crear_Parametro("@tabla", nombreTabla) };
            DataTable t = acceso.LeerBase("OBTENER_DVV", ps);
            acceso.CerrarConexion();

            if (t.Rows.Count == 0 || t.Rows[0]["dvv"] == DBNull.Value) return null;
            return t.Rows[0]["dvv"].ToString().Trim();
        }
    }
    
}
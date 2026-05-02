using BE;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Stock_Mapper
    {
        Acceso acceso = new Acceso();

        public int Cargar_Producto(Producto nuevo_producto)
        {
            try
            {
                acceso.AbrirConexion();
                string NombreSP = "CargarProducto";
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(acceso.Crear_Parametro("@producto_nombre", nuevo_producto.Nombre_Producto));
                parameters.Add(acceso.Crear_Parametro("@precio", nuevo_producto.Precio));
                int filas = acceso.EscribirBase(NombreSP, parameters);
                acceso.CerrarConexion();
                return filas;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable Listar_Productos()
        {
            try
            {
                acceso.AbrirConexion();
                string NombreSP = "ListarProductos";

                DataTable tabla = new DataTable();
                tabla = acceso.LeerBase(NombreSP);

                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Modificar_Producto(Producto producto_modificado)
        {
            try
            {
                acceso.AbrirConexion();
                string NombreSP = "ModificarProducto";

                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(acceso.Crear_Parametro("@producto_nombre", producto_modificado.Nombre_Producto));
                parameters.Add(acceso.Crear_Parametro("@precio", producto_modificado.Precio));
                parameters.Add(acceso.Crear_Parametro("@ID_Producto", producto_modificado.ID_Producto));
                parameters.Add(acceso.Crear_Parametro("@ID_Usuario", producto_modificado.Usuario_Modificador.ID));
                parameters.Add(acceso.Crear_Parametro("@num_tipo_de_modificacion", producto_modificado.Num_Tipo_De_Modificacion));
                parameters.Add(acceso.Crear_Parametro("@fecha_cambio", DateTime.Now));
                int filas = acceso.EscribirBase(NombreSP, parameters);
                acceso.CerrarConexion();
                return filas;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable Listar_Producto_Historial(Producto producto)
        {
            acceso.AbrirConexion();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.Crear_Parametro("@ID_Producto", producto.ID_Producto));

            DataTable tabla = acceso.LeerBase("Listar_Producto_Historial", parametros);

            acceso.CerrarConexion();
            return tabla;
        }
    }
}
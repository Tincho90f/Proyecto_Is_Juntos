using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BE;
using DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BLL
{
    public class Stock_BLL
    {
        /* Stock actual para los productos con precios en el momento
         * Stock historico para el listado de las modificaciones de precios
         * Stock Mapper funciona para ambos
         */
        Stock_Mapper stock_mapper = new Stock_Mapper();
        Stock stock_actual = new Stock();
        Stock stock_historico = new Stock();

        private bool Probar_Existencia(string nombre_producto)
        {
            Consultar_Producto();
            return stock_actual.listado_productos.Any(p => string.Equals(p.Nombre_Producto, nombre_producto, StringComparison.OrdinalIgnoreCase));
        }

        public void Registrar_Producto(string nombre_producto, decimal precio_producto)
        {
            if(Probar_Existencia(nombre_producto) == false)
            {
                Producto producto = new Producto();

                producto.Nombre_Producto = nombre_producto;
                producto.Precio = precio_producto;

                if (stock_mapper.Cargar_Producto(producto) == 0)
                {
                    throw new Exception("Error en la carga del producto");
                }
            }
            else
            {
                throw new Exception("Producto ya creado");
            }
        }

        public Stock Consultar_Producto()
        {
            DataTable tabla = stock_mapper.Listar_Productos();
            stock_actual.listado_productos.Clear();

            foreach (DataRow fila in tabla.Rows)
            {
                Producto producto = new Producto();

                producto.ID_Producto = Convert.ToInt32(fila["ID_Producto"]);
                producto.Nombre_Producto = fila["producto_nombre"].ToString();
                producto.Precio = Convert.ToDecimal(fila["precio"]);

                stock_actual.listado_productos.Add(producto);
            }
            return stock_actual;
        }

        public void Registrar_Modificacion(Producto producto_modificado)
        {

            var listaActual = Consultar_Producto().listado_productos;
            var productoOriginal = listaActual.FirstOrDefault(p => p.ID_Producto == producto_modificado.ID_Producto);

            if (productoOriginal == null)
            {
                throw new Exception("El producto a modificar no existe.");
            }

            if (producto_modificado.Tipo_De_Modificacion != TipoDeModificacion.Restauracion_De_Precio)
            {
                if (producto_modificado.Precio > productoOriginal.Precio)
                {
                    producto_modificado.Tipo_De_Modificacion = TipoDeModificacion.Aumento_De_Precio;
                }
                else if (producto_modificado.Precio < productoOriginal.Precio)
                {
                    producto_modificado.Tipo_De_Modificacion = TipoDeModificacion.Reduccion_De_Precio;
                }
                
            }

            producto_modificado.Num_Tipo_De_Modificacion = (int)producto_modificado.Tipo_De_Modificacion;

            if (stock_mapper.Modificar_Producto(producto_modificado) == 0)
            {
                throw new Exception("Error al guardar la modificación.");
            }
        }


        public void Restaurar_Precio(Producto productoHistorico, Usuario usuarioRestaurador)
        {

            Consultar_Producto();

            var productoActual = stock_actual.listado_productos
                                 .FirstOrDefault(p => p.ID_Producto == productoHistorico.ID_Producto);

            if (productoActual == null)
            {
                throw new Exception("No se puede restaurar. El producto (ID: " + productoHistorico.ID_Producto + ") ya no existe en el stock actual.");
            }

            Producto productoParaRestaurar = new Producto();

            productoParaRestaurar.ID_Producto = productoHistorico.ID_Producto;

           
            productoParaRestaurar.Nombre_Producto = productoActual.Nombre_Producto;

          
            productoParaRestaurar.Precio = productoHistorico.Precio;

            
            productoParaRestaurar.Usuario_Modificador = usuarioRestaurador;
            productoParaRestaurar.Fecha_Modificacion = DateTime.Now;
            productoParaRestaurar.Tipo_De_Modificacion = TipoDeModificacion.Restauracion_De_Precio;

            Registrar_Modificacion(productoParaRestaurar);
        }

        public Stock Consultar_Historial_Producto(Producto producto)
        {
            DataTable tabla = stock_mapper.Listar_Producto_Historial(producto);
            stock_historico.listado_productos.Clear();

            foreach (DataRow fila in tabla.Rows)
            {
                Producto producto_modificado = new Producto();
                producto_modificado.Usuario_Modificador= new Usuario();
                producto_modificado.ID_Producto = Convert.ToInt32(fila["ID_Producto"]);
                producto_modificado.Precio = Convert.ToDecimal(fila["precio_viejo"]);
                producto_modificado.Usuario_Modificador.Nombre = fila["usuario_nombre"].ToString();
                producto_modificado.Tipo_De_Modificacion= (TipoDeModificacion)Convert.ToInt32(fila["num_tipo_modificacion"]);
                producto_modificado.Fecha_Modificacion = Convert.ToDateTime(fila["fecha_cambio"]);
                stock_historico.listado_productos.Add(producto_modificado);
            }
            return stock_historico;
        }
    }
}
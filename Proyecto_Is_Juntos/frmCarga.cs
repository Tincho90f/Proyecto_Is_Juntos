using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using DAL;
using Servicios;

namespace Proyecto_Is_Juntos
{
    public partial class frmCargaModificacion : BaseForm
    {
        public Usuario usuario_logueado;
        Bitacora_BLL bitacora = new Bitacora_BLL();

        public frmCargaModificacion()
        {
            InitializeComponent();
            DataGridView_Productos_CargaModificacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmCarga_Load(object sender, EventArgs e)
        {
            Mostrar_Productos();
        }

        private void btn_Aceptar_Carga_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_NombreProducto_CargaModificacion == null && Txt_PrecioProducto_CargaModificacion == null)
                {
                    MessageBox.Show("Olvidó completar un campo");
                }
                else
                {
                    Stock_BLL stock_BLL = new Stock_BLL();
                    stock_BLL.Registrar_Producto(Txt_NombreProducto_CargaModificacion.Text,Convert.ToDecimal(Txt_PrecioProducto_CargaModificacion.Text));

                    Mostrar_Productos();

                    bitacora.Registrar_Operacion(usuario_logueado, 3);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Manejo de evento para seleccionar el producto que se quiere modificar.
        private void DataGridView_CargaModificacion_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Txt_NombreModificacion_CargaModificacion.Text = DataGridView_Productos_CargaModificacion.SelectedRows[0].Cells[1].Value.ToString();
            Txt_PrecioModificacion_CargaModificacion.Text = DataGridView_Productos_CargaModificacion.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btn_AceptarModificacion_CargaModificacion_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones visuales básicas
                if (DataGridView_Productos_CargaModificacion.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un producto de la grilla.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(Txt_NombreModificacion_CargaModificacion.Text) ||
                    string.IsNullOrWhiteSpace(Txt_PrecioModificacion_CargaModificacion.Text))
                {
                    MessageBox.Show("Complete los campos.");
                    return;
                }

                Producto producto_modificar = new Producto();

                if (int.TryParse(DataGridView_Productos_CargaModificacion.SelectedRows[0].Cells[0].Value.ToString(), out int idProd))
                {
                    producto_modificar.ID_Producto = idProd;
                }

                producto_modificar.Nombre_Producto = Txt_NombreModificacion_CargaModificacion.Text;
                producto_modificar.Precio = Convert.ToDecimal(Txt_PrecioModificacion_CargaModificacion.Text);

                producto_modificar.Usuario_Modificador = usuario_logueado;

                Stock_BLL stock_BLL = new Stock_BLL();
                stock_BLL.Registrar_Modificacion(producto_modificar);

                MessageBox.Show("Modificación registrada correctamente.");
                Mostrar_Productos();

                Txt_NombreModificacion_CargaModificacion.Text = "";
                Txt_PrecioModificacion_CargaModificacion.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Txt_PrecioProducto_CargaModificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; 
            }

            TextBox txt = sender as TextBox;
            if (e.KeyChar == '.' && txt.Text.Contains('.'))
            {
                e.Handled = true; 
            }
        }

        private void Txt_PrecioModificacion_CargaModificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; 
            }

            
            TextBox txt = sender as TextBox;
            if (e.KeyChar == '.' && txt.Text.Contains('.'))
            {
                e.Handled = true; 
            }
        }

        private void Mostrar_Productos()
        {
            Stock_BLL stock_BLL = new Stock_BLL();
            DataGridView_Productos_CargaModificacion.DataSource = null;

            Stock stock = stock_BLL.Consultar_Producto();
            DataGridView_Productos_CargaModificacion.DataSource = stock.listado_productos;
            DataGridView_Productos_CargaModificacion.Columns["Usuario_Modificador"].Visible = false;
            DataGridView_Productos_CargaModificacion.Columns["Fecha_Modificacion"].Visible = false;
            DataGridView_Productos_CargaModificacion.Columns["Num_Tipo_De_Modificacion"].Visible = false;
            DataGridView_Productos_CargaModificacion.Columns["Tipo_De_Modificacion"].Visible = false;
        }
    }
}


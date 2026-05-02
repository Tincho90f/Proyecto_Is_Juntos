using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class frmHistorial : BaseForm
    {
        public Usuario usuario_logueado;
        private Stock_BLL stockBLL = new Stock_BLL();

        private Producto productoSeleccionadoActual;

        public frmHistorial()
        {
            InitializeComponent();
            ConfigurarGrillas();
        }

        private void ConfigurarGrillas()
        {
            DataGridView_Productos_Historial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView_Productos_Historial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView_Productos_Historial.MultiSelect = false;
            DataGridView_Productos_Historial.ReadOnly = true;

            DataGridView_ModificacionesProducto_Historial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView_ModificacionesProducto_Historial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView_ModificacionesProducto_Historial.MultiSelect = false;
            DataGridView_ModificacionesProducto_Historial.ReadOnly = true;
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            Mostrar_Productos();
        }

        private void Mostrar_Productos()
        {
            DataGridView_Productos_Historial.DataSource = null;
            Stock stock_actual = stockBLL.Consultar_Producto();
            DataGridView_Productos_Historial.DataSource = stock_actual.listado_productos;

            OcultarColumna(DataGridView_Productos_Historial, "Usuario_Modificador");
            OcultarColumna(DataGridView_Productos_Historial, "Fecha_Modificacion");
            OcultarColumna(DataGridView_Productos_Historial, "Num_Tipo_De_Modificacion");
            OcultarColumna(DataGridView_Productos_Historial, "Tipo_De_Modificacion");
        }

        // Evento: Doble click en la izquierda carga la derecha
        private void DataGridView_Productos_Historial_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            productoSeleccionadoActual = (Producto)DataGridView_Productos_Historial.SelectedRows[0].DataBoundItem;
            Mostrar_Productos_Historial(productoSeleccionadoActual);
        }

        private void Mostrar_Productos_Historial(Producto producto)
        {
            DataGridView_ModificacionesProducto_Historial.DataSource = null;

            Stock stock_historico_BE = stockBLL.Consultar_Historial_Producto(producto);
            DataGridView_ModificacionesProducto_Historial.DataSource = stock_historico_BE.listado_productos;

            OcultarColumna(DataGridView_ModificacionesProducto_Historial, "Nombre_Producto"); // Ya sabemos el nombre
            OcultarColumna(DataGridView_ModificacionesProducto_Historial, "ID_Producto");
            OcultarColumna(DataGridView_ModificacionesProducto_Historial, "Num_Tipo_De_Modificacion"); // Mostraremos el Enum formateado
        }

        private void Btn_RetornarModificacion_Historial_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView_ModificacionesProducto_Historial.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un registro del historial (derecha) para restaurar.");
                    return;
                }

                Producto estadoHistorico = (Producto)DataGridView_ModificacionesProducto_Historial.SelectedRows[0].DataBoundItem;

                string mensaje = $"¿Está seguro de restaurar el precio a ${estadoHistorico.Precio}?\n" +
                                 $"Estado del: {estadoHistorico.Fecha_Modificacion}";

                if (MessageBox.Show(mensaje, "Confirmar Rollback", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    stockBLL.Restaurar_Precio(estadoHistorico, usuario_logueado);

                    MessageBox.Show("Precio restaurado exitosamente.");

                    Mostrar_Productos(); 

                    if (productoSeleccionadoActual != null)
                        Mostrar_Productos_Historial(productoSeleccionadoActual); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restaurar: " + ex.Message);
            }
        }

        private void OcultarColumna(DataGridView dgv, string nombreCol)
        {
            if (dgv.Columns[nombreCol] != null) dgv.Columns[nombreCol].Visible = false;
        }
    }
}

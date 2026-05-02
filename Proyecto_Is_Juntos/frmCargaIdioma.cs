using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Is_Juntos
{
    public partial class frmCargaIdioma : BaseForm
    {
        public Usuario usuario_logueado;
        Bitacora_BLL bitacora = new Bitacora_BLL();
        public frmCargaIdioma()
        {
            InitializeComponent();
            DataGridView_CargaIdiomas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        CargaIdiomas_BLL cargaIdiomas_BLL = new CargaIdiomas_BLL();

        private void btnModificarIdioma_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBox1.SelectedValue);
            if (id == null)
            {
                MessageBox.Show("Seleccione un idioma para modificar.");
                return;
            }

            var tabla = cargaIdiomas_BLL.CargarGrid(id);
            DataGridView_CargaIdiomas.DataSource = tabla;
            DataGridView_CargaIdiomas.Columns["ID_Etiqueta"].ReadOnly = true;
            DataGridView_CargaIdiomas.Columns["nombre_etiqueta"].ReadOnly = true;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBox1.SelectedValue);
            if (id == null)
            {
                MessageBox.Show("No hay idioma seleccionado.");
                return;
            }

            DataTable tabla = (DataTable)DataGridView_CargaIdiomas.DataSource;
            cargaIdiomas_BLL.GuardarCambiosIdiomaExistente(id, tabla);

            bitacora.Registrar_Operacion(usuario_logueado, 5);
            MessageBox.Show("Cambios guardados.");
        }

        private void btnNuevoIdioma_Click(object sender, EventArgs e)
        {
            // Carga etiquetas con traducción vacía
            int a = Convert.ToInt32(null);
            DataTable tabla = cargaIdiomas_BLL.CargarGrid(a);
            DataGridView_CargaIdiomas.DataSource = tabla;
            DataGridView_CargaIdiomas.Columns["ID_Etiqueta"].ReadOnly = true;
            DataGridView_CargaIdiomas.Columns["nombre_etiqueta"].ReadOnly = true;

            Txt_NombreIdioma_Idioma.Enabled = true;
            Txt_NombreIdioma_Idioma.Text = "";   // el usuario define el nombre
            comboBox1.SelectedIndex = -1; // deseleccionar
        }

        private void Btn_CargarIdioma_Idioma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_NombreIdioma_Idioma.Text))
            {
                Txt_NombreIdioma_Idioma.Focus();
                return;
            }
            bitacora.Registrar_Operacion(usuario_logueado, 6);
            DataTable tabla = (DataTable)DataGridView_CargaIdiomas.DataSource;
            int idNuevo = cargaIdiomas_BLL.CrearIdiomaYGuardar(Txt_NombreIdioma_Idioma.Text.Trim(), tabla);
        }

        private void frmCargaIdioma_Load(object sender, EventArgs e)
        {
            CargarIdiomas();
        }

        private void CargarIdiomas()
        {
            List<Idioma> idiomas = cargaIdiomas_BLL.Consultar_Idiomas();
            comboBox1.DataSource = idiomas;
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "ID_Idioma";
            comboBox1.SelectedIndex = -1;
        }

    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Is_Juntos
{
    public partial class frmIdioma : BaseForm
    {
        public Usuario usuario_logueado;
        CargaIdiomas_BLL cargaIdiomas_BLL = new CargaIdiomas_BLL();
        Bitacora_BLL bitacora = new Bitacora_BLL();

        public frmIdioma()
        {
            InitializeComponent();
        }

        private void btn_CambiarIdioma_Idioma_Click(object sender, EventArgs e)
        {
            if(ComboBox_SeleccionIdioma_Idioma.SelectedItem != null)
            {
                GestorIdioma_BLL.Instancia.Cambiar_Idioma(Convert.ToInt32(ComboBox_SeleccionIdioma_Idioma.SelectedValue));
                bitacora.Registrar_Operacion(usuario_logueado, 4);
            }
        }

        private void frmIdioma_Load(object sender, EventArgs e)
        {
            CargarIdiomas();
        }

        private void CargarIdiomas()
        {
            List<Idioma> idiomas = cargaIdiomas_BLL.Consultar_Idiomas();
            ComboBox_SeleccionIdioma_Idioma.DataSource = idiomas;
            ComboBox_SeleccionIdioma_Idioma.DisplayMember = "nombre";
            ComboBox_SeleccionIdioma_Idioma.ValueMember = "ID_Idioma";
            ComboBox_SeleccionIdioma_Idioma.SelectedIndex = -1; // ninguno seleccionado por defecto
        }
    }
}

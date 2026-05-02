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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using BE;
using BLL;
using DAL;
using Servicios;

namespace Proyecto_Is_Juntos
{
    public partial class frmBitacora : BaseForm
    {
        public Usuario usuario_logueado;
        Bitacora_BLL BLL_bitacora = new Bitacora_BLL();

        public frmBitacora()
        {
            InitializeComponent();

            DataGridView_Bitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Carga del enum: TiposdeOperacion en la bitacora para usarlo como filtro

            var tipos = Enum.GetValues(typeof(TiposDeOperacion))
                                .Cast<TiposDeOperacion>()
                                .Select(t => new { Text = t.ToString(), Value = (TiposDeOperacion?)t })
                                .ToList();

            tipos.Insert(0, new { Text = "(Todos)", Value = (TiposDeOperacion?)null });

            ComboBox_TipoDeOperacion_Bitacora.DisplayMember = "Text";
            ComboBox_TipoDeOperacion_Bitacora.ValueMember = "Value";
            ComboBox_TipoDeOperacion_Bitacora.DataSource = tipos;
        }


        private void frmBitacora_Load(object sender, EventArgs e)
        {
            DateTime_Bitacora.Enabled = false;
        }

        private void btn_CargarBitacora_Click(object sender, EventArgs e)
        {
            MostrarMovimientos();
            BLL_bitacora.Registrar_Operacion(usuario_logueado, 3);
        }

        private void chechkBox_Fecha_Bitacora_CheckedChanged(object sender, EventArgs e)
        {
            if (chechkBox_Fecha_Bitacora.Checked == true)
            {
                DateTime_Bitacora.Enabled = true;
            }
            else
            {
                DateTime_Bitacora.Enabled = false;
            }
        }

        public void MostrarMovimientos()
        {
            DataGridView_Bitacora.DataSource = null;
            BLL_bitacora.Registrar_Operacion(usuario_logueado, 2);
            Bitacora bitacora = BLL_bitacora.Consultar_Operacion();

            /* Se crea un id temporal para el filtrado que sale del textbox 
             * correspondiente,se le sacan los espacios en blanco y se guarda 
             * el idTmp.
             */

            int idTmp;
            bool filtraId = int.TryParse(Txt_IDOperacion_Bitacora.Text.Trim(), out idTmp);

            string usuarioTxt = Txt_Usuario_Bitacora.Text?.Trim();

            bitacora.operaciones_bitacora = (from o in bitacora.operaciones_bitacora
                                             where (!filtraId || o.ID_Operacion == idTmp)
                                                && (string.IsNullOrWhiteSpace(usuarioTxt) ||
                                                    (o.Usuario?.Nombre ?? "").IndexOf(usuarioTxt,
                                                       StringComparison.OrdinalIgnoreCase) >= 0)
                                                && (!(ComboBox_TipoDeOperacion_Bitacora.SelectedValue is TiposDeOperacion tsel)
                                                       || o.Tipo_Operacion == tsel)
                                                && (!chechkBox_Fecha_Bitacora.Checked
                                                       || o.Fecha_Operacion.Date == DateTime_Bitacora.Value.Date)
                                             orderby o.Fecha_Operacion descending
                                             select o).ToList();

            DataGridView_Bitacora.DataSource = bitacora.operaciones_bitacora;
            DataGridView_Bitacora.Columns["Num_Tipo_Operacion"].Visible = false;
        }

    }
}

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
    public partial class frmLogin : BaseForm
    {
        public frmLogin()
        {
            InitializeComponent();

        }

        Bitacora_BLL bitacora= new Bitacora_BLL();

        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.Nombre = NombreUsuario_Textbox.Text;
                usuario.Password = Password_Textbox.Text;

                Usuario_BLL usuario_BLL = new Usuario_BLL();

                if(NombreUsuario_Textbox == null && Password_Textbox.Text == null)
                {
                    MessageBox.Show("Por favor, debe completar ambos campos para iniciar sesión");
                }
                else
                {
                    if (usuario_BLL.Logueo(usuario) == true)
                    {
                        this.Hide();
                        frmMenu frmMenu = new frmMenu();
                        frmMenu.usuario_logueado = usuario;
                        frmMenu.Show();
                        bitacora.Registrar_Operacion(usuario, 0);
                        
                    }
                }

            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

        private void frmLogin_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
            {
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show(
                  "¿Está seguro que desea cerrar la aplicación?",
                  "Confirmación",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
  
        }

        
    }
}

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
    public partial class frmMenu : BaseForm
    {
        public Usuario usuario_logueado;
        Bitacora_BLL bitacora = new Bitacora_BLL();

        public frmMenu()
        {
            InitializeComponent();
        }

        private void bitacoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBitacora frmBitacora = new frmBitacora();
            frmBitacora.MdiParent = this;
            frmBitacora.usuario_logueado = usuario_logueado;
            frmBitacora.Show();
        }

        private void cargaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaModificacion frmCarga = new frmCargaModificacion();
            frmCarga.MdiParent = this;
            frmCarga.usuario_logueado = usuario_logueado;
            frmCarga.Show();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorial frmHistorial = new frmHistorial();
            frmHistorial.MdiParent = this;
            frmHistorial.usuario_logueado = usuario_logueado;
            frmHistorial.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SessionManager.Logout();
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            bitacora.Registrar_Operacion(usuario_logueado, 1);
        }

        private void idiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIdioma frmIdioma = new frmIdioma();
            frmIdioma.MdiParent = this;
            frmIdioma.usuario_logueado = usuario_logueado;
            frmIdioma.Show();
        }

        private void ToolStripItem_NuevoIdioma_Click(object sender, EventArgs e)
        {
            frmCargaIdioma frmCargaIdioma = new frmCargaIdioma();
            frmCargaIdioma.MdiParent = this;
            frmCargaIdioma.usuario_logueado = usuario_logueado;
            frmCargaIdioma.Show();
        }

        private void ToolStripItem_Permisos_Click(object sender, EventArgs e)
        {
            frmPermisos frmPermisos = new frmPermisos();
            frmPermisos.MdiParent = this;
            frmPermisos.usuario_logueado = usuario_logueado;
            frmPermisos.Show();
        }

        private void ToolStripItem_PermisosUsuarios_Click(object sender, EventArgs e)
        {
            frmPermisosUsuarios frmPermisosUsuarios = new frmPermisosUsuarios();
            frmPermisosUsuarios.MdiParent = this;
            frmPermisosUsuarios.usuario_logueado = usuario_logueado;
            frmPermisosUsuarios.Show();
        }

        //Manejo de evento para cerrar sesion y aplicación cuando se cierra el menú. 
        private bool _confirmedExit = false;
        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_confirmedExit || e.CloseReason != CloseReason.UserClosing)
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
                    _confirmedExit = true;
                    SessionManager.Logout();
                    bitacora.Registrar_Operacion(usuario_logueado, 1);
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            try
            {
                VerificarDigito(usuario_logueado);
                OcultarComposite();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void OcultarComposite()
        {
            Usuario_BLL usuarioBLL = new Usuario_BLL();

            bool tieneAccesso = usuarioBLL.TienePermiso(SessionManager.UsuarioActual, "Acceso_Bitacora");

            if (!tieneAccesso)
            {
                ToolStripItem_Bitacora.Visible = false;
            }
        }

        private void VerificarDigito(Usuario usuario)
        {
            VerificadorBLL verificador = new VerificadorBLL();
            List<string> errores = verificador.VerificarIntegridad();

            if (errores.Count > 0)
            {

                string mensajeError = string.Join("\n", errores);
                Usuario_BLL usuarioBLL = new Usuario_BLL();

                bool tieneAccesso = usuarioBLL.TienePermiso(SessionManager.UsuarioActual, "Verificador");

                if (tieneAccesso == true)
                {
                    DialogResult result = MessageBox.Show(
                        "⚠️ ALERTA DE SEGURIDAD ⚠️\n\n" +
                        "La base de datos ha sido alterada externamente:\n" +
                        mensajeError + "\n\n" +
                        "Opciones:\n" +
                        "SI: RESTAURAR una copia de seguridad (Recomendado).\n" +
                        "NO: RECALCULAR dígitos (Aceptar cambios como válidos).\n" +
                        "CANCELAR: Salir del sistema.",
                        "Falla de Integridad",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Error
                    );

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            string rutaBackup = @"C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\Backup\Proyecto_Is_Juntos.bak";


                            Backup_BLL backupBLL = new Backup_BLL();


                            if (!System.IO.File.Exists(rutaBackup))
                            {
                                MessageBox.Show("No se encontró el archivo de respaldo en la ruta esperada:\n" + rutaBackup, "Error de Archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }


                            backupBLL.RealizarRestore(rutaBackup);

                            MessageBox.Show("Base de datos restaurada exitosamente.\nLa aplicación se reiniciará para aplicar los cambios.");


                            Application.Restart();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error crítico al restaurar: " + ex.Message);
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        verificador.RecalcularTodosYGuardar();
                        MessageBox.Show("Dígitos recalculados. Se asume la nueva integridad.");
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {

                    MessageBox.Show("Error de integridad detectado. Contacte al administrador.");
                    Application.Exit();
                }
                return;
            }
        }
    }
}

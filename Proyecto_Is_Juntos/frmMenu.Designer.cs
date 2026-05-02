namespace Proyecto_Is_Juntos
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStrip_Servicios = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItem_Bitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItem_Productos = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItem_Carga = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItem_Historial = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItem_Permisos = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItem_PermisosUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItem_CerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItem_Idioma = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripItem_NuevoIdioma = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.Location = new System.Drawing.Point(0, 0);
            this.btn_CerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(56, 19);
            this.btn_CerrarSesion.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_Servicios,
            this.ToolStrip_Usuario});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(982, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStrip_Servicios
            // 
            this.ToolStrip_Servicios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripItem_Bitacora,
            this.ToolStripItem_Productos,
            this.ToolStripItem_Permisos,
            this.ToolStripItem_PermisosUsuarios});
            this.ToolStrip_Servicios.Name = "ToolStrip_Servicios";
            this.ToolStrip_Servicios.Size = new System.Drawing.Size(65, 20);
            this.ToolStrip_Servicios.Text = "Servicios";
            // 
            // ToolStripItem_Bitacora
            // 
            this.ToolStripItem_Bitacora.Name = "ToolStripItem_Bitacora";
            this.ToolStripItem_Bitacora.Size = new System.Drawing.Size(170, 22);
            this.ToolStripItem_Bitacora.Text = "Bitacora";
            this.ToolStripItem_Bitacora.Click += new System.EventHandler(this.bitacoraToolStripMenuItem1_Click);
            // 
            // ToolStripItem_Productos
            // 
            this.ToolStripItem_Productos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripItem_Carga,
            this.ToolStripItem_Historial});
            this.ToolStripItem_Productos.Name = "ToolStripItem_Productos";
            this.ToolStripItem_Productos.Size = new System.Drawing.Size(170, 22);
            this.ToolStripItem_Productos.Text = "Productos";
            // 
            // ToolStripItem_Carga
            // 
            this.ToolStripItem_Carga.Name = "ToolStripItem_Carga";
            this.ToolStripItem_Carga.Size = new System.Drawing.Size(118, 22);
            this.ToolStripItem_Carga.Text = "Carga";
            this.ToolStripItem_Carga.Click += new System.EventHandler(this.cargaToolStripMenuItem_Click);
            // 
            // ToolStripItem_Historial
            // 
            this.ToolStripItem_Historial.Name = "ToolStripItem_Historial";
            this.ToolStripItem_Historial.Size = new System.Drawing.Size(118, 22);
            this.ToolStripItem_Historial.Text = "Historial";
            this.ToolStripItem_Historial.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
            // 
            // ToolStripItem_Permisos
            // 
            this.ToolStripItem_Permisos.Name = "ToolStripItem_Permisos";
            this.ToolStripItem_Permisos.Size = new System.Drawing.Size(170, 22);
            this.ToolStripItem_Permisos.Text = "Permisos";
            this.ToolStripItem_Permisos.Click += new System.EventHandler(this.ToolStripItem_Permisos_Click);
            // 
            // ToolStripItem_PermisosUsuarios
            // 
            this.ToolStripItem_PermisosUsuarios.Name = "ToolStripItem_PermisosUsuarios";
            this.ToolStripItem_PermisosUsuarios.Size = new System.Drawing.Size(170, 22);
            this.ToolStripItem_PermisosUsuarios.Text = "Permisos Usuarios";
            this.ToolStripItem_PermisosUsuarios.Click += new System.EventHandler(this.ToolStripItem_PermisosUsuarios_Click);
            // 
            // ToolStrip_Usuario
            // 
            this.ToolStrip_Usuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripItem_CerrarSesion,
            this.ToolStripItem_Idioma,
            this.ToolStripItem_NuevoIdioma});
            this.ToolStrip_Usuario.Name = "ToolStrip_Usuario";
            this.ToolStrip_Usuario.Size = new System.Drawing.Size(59, 20);
            this.ToolStrip_Usuario.Text = "Usuario";
            // 
            // ToolStripItem_CerrarSesion
            // 
            this.ToolStripItem_CerrarSesion.Name = "ToolStripItem_CerrarSesion";
            this.ToolStripItem_CerrarSesion.Size = new System.Drawing.Size(149, 22);
            this.ToolStripItem_CerrarSesion.Text = "Cerrar Sesión";
            this.ToolStripItem_CerrarSesion.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // ToolStripItem_Idioma
            // 
            this.ToolStripItem_Idioma.Name = "ToolStripItem_Idioma";
            this.ToolStripItem_Idioma.Size = new System.Drawing.Size(149, 22);
            this.ToolStripItem_Idioma.Text = "Idioma";
            this.ToolStripItem_Idioma.Click += new System.EventHandler(this.idiomaToolStripMenuItem_Click);
            // 
            // ToolStripItem_NuevoIdioma
            // 
            this.ToolStripItem_NuevoIdioma.Name = "ToolStripItem_NuevoIdioma";
            this.ToolStripItem_NuevoIdioma.Size = new System.Drawing.Size(149, 22);
            this.ToolStripItem_NuevoIdioma.Text = "Nuevo Idioma";
            this.ToolStripItem_NuevoIdioma.Click += new System.EventHandler(this.ToolStripItem_NuevoIdioma_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 392);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_CerrarSesion);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CerrarSesion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Servicios;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItem_Bitacora;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Usuario;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItem_CerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItem_Productos;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItem_Carga;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItem_Historial;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItem_Idioma;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItem_NuevoIdioma;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItem_Permisos;
        private System.Windows.Forms.ToolStripMenuItem ToolStripItem_PermisosUsuarios;
    }
}
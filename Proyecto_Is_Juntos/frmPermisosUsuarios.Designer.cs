namespace Proyecto_Is_Juntos
{
    partial class frmPermisosUsuarios
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
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.treeAsignados = new System.Windows.Forms.TreeView();
            this.Lbl_Usuarios_PermisosUsuarios = new System.Windows.Forms.Label();
            this.lstDisponibles = new System.Windows.Forms.ListBox();
            this.Btn_Asignar_PermisosUsuarios = new System.Windows.Forms.Button();
            this.Btn_Quitar_PermisosUsuarios = new System.Windows.Forms.Button();
            this.Btn_Refrescar_PermisosUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(681, 16);
            this.cboUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(231, 24);
            this.cboUsuarios.TabIndex = 0;
            this.cboUsuarios.SelectedIndexChanged += new System.EventHandler(this.cboUsuarios_SelectedIndexChanged);
            // 
            // treeAsignados
            // 
            this.treeAsignados.Location = new System.Drawing.Point(16, 15);
            this.treeAsignados.Margin = new System.Windows.Forms.Padding(4);
            this.treeAsignados.Name = "treeAsignados";
            this.treeAsignados.Size = new System.Drawing.Size(305, 532);
            this.treeAsignados.TabIndex = 1;
            // 
            // Lbl_Usuarios_PermisosUsuarios
            // 
            this.Lbl_Usuarios_PermisosUsuarios.AutoSize = true;
            this.Lbl_Usuarios_PermisosUsuarios.Location = new System.Drawing.Point(616, 20);
            this.Lbl_Usuarios_PermisosUsuarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Usuarios_PermisosUsuarios.Name = "Lbl_Usuarios_PermisosUsuarios";
            this.Lbl_Usuarios_PermisosUsuarios.Size = new System.Drawing.Size(54, 16);
            this.Lbl_Usuarios_PermisosUsuarios.TabIndex = 2;
            this.Lbl_Usuarios_PermisosUsuarios.Text = "Usuario";
            // 
            // lstDisponibles
            // 
            this.lstDisponibles.FormattingEnabled = true;
            this.lstDisponibles.ItemHeight = 16;
            this.lstDisponibles.Location = new System.Drawing.Point(331, 15);
            this.lstDisponibles.Margin = new System.Windows.Forms.Padding(4);
            this.lstDisponibles.Name = "lstDisponibles";
            this.lstDisponibles.Size = new System.Drawing.Size(275, 532);
            this.lstDisponibles.TabIndex = 3;
            // 
            // Btn_Asignar_PermisosUsuarios
            // 
            this.Btn_Asignar_PermisosUsuarios.Location = new System.Drawing.Point(679, 82);
            this.Btn_Asignar_PermisosUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Asignar_PermisosUsuarios.Name = "Btn_Asignar_PermisosUsuarios";
            this.Btn_Asignar_PermisosUsuarios.Size = new System.Drawing.Size(235, 44);
            this.Btn_Asignar_PermisosUsuarios.TabIndex = 4;
            this.Btn_Asignar_PermisosUsuarios.Text = "Asisgnar";
            this.Btn_Asignar_PermisosUsuarios.UseVisualStyleBackColor = true;
            this.Btn_Asignar_PermisosUsuarios.Click += new System.EventHandler(this.Btn_Asignar_PermisosUsuarios_Click);
            // 
            // Btn_Quitar_PermisosUsuarios
            // 
            this.Btn_Quitar_PermisosUsuarios.Location = new System.Drawing.Point(679, 169);
            this.Btn_Quitar_PermisosUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Quitar_PermisosUsuarios.Name = "Btn_Quitar_PermisosUsuarios";
            this.Btn_Quitar_PermisosUsuarios.Size = new System.Drawing.Size(235, 42);
            this.Btn_Quitar_PermisosUsuarios.TabIndex = 5;
            this.Btn_Quitar_PermisosUsuarios.Text = "Quitar";
            this.Btn_Quitar_PermisosUsuarios.UseVisualStyleBackColor = true;
            this.Btn_Quitar_PermisosUsuarios.Click += new System.EventHandler(this.Btn_Quitar_PermisosUsuarios_Click);
            // 
            // Btn_Refrescar_PermisosUsuarios
            // 
            this.Btn_Refrescar_PermisosUsuarios.Location = new System.Drawing.Point(615, 494);
            this.Btn_Refrescar_PermisosUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Refrescar_PermisosUsuarios.Name = "Btn_Refrescar_PermisosUsuarios";
            this.Btn_Refrescar_PermisosUsuarios.Size = new System.Drawing.Size(377, 54);
            this.Btn_Refrescar_PermisosUsuarios.TabIndex = 6;
            this.Btn_Refrescar_PermisosUsuarios.Text = "Refrescar";
            this.Btn_Refrescar_PermisosUsuarios.UseVisualStyleBackColor = true;
            this.Btn_Refrescar_PermisosUsuarios.Click += new System.EventHandler(this.Btn_Refrescar_PermisosUsuarios_Click);
            // 
            // frmPermisosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 559);
            this.Controls.Add(this.Btn_Refrescar_PermisosUsuarios);
            this.Controls.Add(this.Btn_Quitar_PermisosUsuarios);
            this.Controls.Add(this.Btn_Asignar_PermisosUsuarios);
            this.Controls.Add(this.lstDisponibles);
            this.Controls.Add(this.Lbl_Usuarios_PermisosUsuarios);
            this.Controls.Add(this.treeAsignados);
            this.Controls.Add(this.cboUsuarios);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1021, 606);
            this.MinimumSize = new System.Drawing.Size(1021, 606);
            this.Name = "frmPermisosUsuarios";
            this.Text = "Permisos Usuarios";
            this.Load += new System.EventHandler(this.frmPermisosUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboUsuarios;
        private System.Windows.Forms.TreeView treeAsignados;
        private System.Windows.Forms.Label Lbl_Usuarios_PermisosUsuarios;
        private System.Windows.Forms.ListBox lstDisponibles;
        private System.Windows.Forms.Button Btn_Asignar_PermisosUsuarios;
        private System.Windows.Forms.Button Btn_Quitar_PermisosUsuarios;
        private System.Windows.Forms.Button Btn_Refrescar_PermisosUsuarios;
    }
}
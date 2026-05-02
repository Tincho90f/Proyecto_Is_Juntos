namespace Proyecto_Is_Juntos
{
    partial class frmPermisos
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
            this.GroupBox_NPermisos_Permisos = new System.Windows.Forms.GroupBox();
            this.BtnCrear_Crear_Permisos = new System.Windows.Forms.Button();
            this.Rb_Familia_Permisos = new System.Windows.Forms.RadioButton();
            this.Rb_Patente_Permisos = new System.Windows.Forms.RadioButton();
            this.Lbl_Descripcion_Permisos = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre_Permisos = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.treePermisos = new System.Windows.Forms.TreeView();
            this.GroupBox_APermisos_Permisos = new System.Windows.Forms.GroupBox();
            this.Btn_Refrescar_Permisos = new System.Windows.Forms.Button();
            this.Btn_QuitarNodo_Permisos = new System.Windows.Forms.Button();
            this.Btn_AgregarHijo_Permisos = new System.Windows.Forms.Button();
            this.lstDisponibles = new System.Windows.Forms.ListBox();
            this.GroupBox_NPermisos_Permisos.SuspendLayout();
            this.GroupBox_APermisos_Permisos.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_NPermisos_Permisos
            // 
            this.GroupBox_NPermisos_Permisos.Controls.Add(this.BtnCrear_Crear_Permisos);
            this.GroupBox_NPermisos_Permisos.Controls.Add(this.Rb_Familia_Permisos);
            this.GroupBox_NPermisos_Permisos.Controls.Add(this.Rb_Patente_Permisos);
            this.GroupBox_NPermisos_Permisos.Controls.Add(this.Lbl_Descripcion_Permisos);
            this.GroupBox_NPermisos_Permisos.Controls.Add(this.txtDescripcion);
            this.GroupBox_NPermisos_Permisos.Controls.Add(this.Lbl_Nombre_Permisos);
            this.GroupBox_NPermisos_Permisos.Controls.Add(this.txtNombre);
            this.GroupBox_NPermisos_Permisos.Location = new System.Drawing.Point(444, 13);
            this.GroupBox_NPermisos_Permisos.Name = "GroupBox_NPermisos_Permisos";
            this.GroupBox_NPermisos_Permisos.Size = new System.Drawing.Size(277, 152);
            this.GroupBox_NPermisos_Permisos.TabIndex = 0;
            this.GroupBox_NPermisos_Permisos.TabStop = false;
            this.GroupBox_NPermisos_Permisos.Text = "Permiso/Familia";
            // 
            // BtnCrear_Crear_Permisos
            // 
            this.BtnCrear_Crear_Permisos.Location = new System.Drawing.Point(10, 115);
            this.BtnCrear_Crear_Permisos.Name = "BtnCrear_Crear_Permisos";
            this.BtnCrear_Crear_Permisos.Size = new System.Drawing.Size(261, 23);
            this.BtnCrear_Crear_Permisos.TabIndex = 6;
            this.BtnCrear_Crear_Permisos.Text = "Crear";
            this.BtnCrear_Crear_Permisos.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // Rb_Familia_Permisos
            // 
            this.Rb_Familia_Permisos.AutoSize = true;
            this.Rb_Familia_Permisos.Location = new System.Drawing.Point(214, 91);
            this.Rb_Familia_Permisos.Name = "Rb_Familia_Permisos";
            this.Rb_Familia_Permisos.Size = new System.Drawing.Size(57, 17);
            this.Rb_Familia_Permisos.TabIndex = 5;
            this.Rb_Familia_Permisos.TabStop = true;
            this.Rb_Familia_Permisos.Text = "Familia";
            this.Rb_Familia_Permisos.UseVisualStyleBackColor = true;
            // 
            // Rb_Patente_Permisos
            // 
            this.Rb_Patente_Permisos.AutoSize = true;
            this.Rb_Patente_Permisos.Location = new System.Drawing.Point(9, 91);
            this.Rb_Patente_Permisos.Name = "Rb_Patente_Permisos";
            this.Rb_Patente_Permisos.Size = new System.Drawing.Size(62, 17);
            this.Rb_Patente_Permisos.TabIndex = 4;
            this.Rb_Patente_Permisos.TabStop = true;
            this.Rb_Patente_Permisos.Text = "Patente";
            this.Rb_Patente_Permisos.UseVisualStyleBackColor = true;
            // 
            // Lbl_Descripcion_Permisos
            // 
            this.Lbl_Descripcion_Permisos.AutoSize = true;
            this.Lbl_Descripcion_Permisos.Location = new System.Drawing.Point(6, 49);
            this.Lbl_Descripcion_Permisos.Name = "Lbl_Descripcion_Permisos";
            this.Lbl_Descripcion_Permisos.Size = new System.Drawing.Size(63, 13);
            this.Lbl_Descripcion_Permisos.TabIndex = 3;
            this.Lbl_Descripcion_Permisos.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(71, 46);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // Lbl_Nombre_Permisos
            // 
            this.Lbl_Nombre_Permisos.AutoSize = true;
            this.Lbl_Nombre_Permisos.Location = new System.Drawing.Point(7, 23);
            this.Lbl_Nombre_Permisos.Name = "Lbl_Nombre_Permisos";
            this.Lbl_Nombre_Permisos.Size = new System.Drawing.Size(44, 13);
            this.Lbl_Nombre_Permisos.TabIndex = 1;
            this.Lbl_Nombre_Permisos.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(71, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // treePermisos
            // 
            this.treePermisos.Location = new System.Drawing.Point(13, 13);
            this.treePermisos.Name = "treePermisos";
            this.treePermisos.Size = new System.Drawing.Size(334, 425);
            this.treePermisos.TabIndex = 1;
            this.treePermisos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treePermisos_AfterSelect);
            // 
            // GroupBox_APermisos_Permisos
            // 
            this.GroupBox_APermisos_Permisos.Controls.Add(this.Btn_Refrescar_Permisos);
            this.GroupBox_APermisos_Permisos.Controls.Add(this.Btn_QuitarNodo_Permisos);
            this.GroupBox_APermisos_Permisos.Controls.Add(this.Btn_AgregarHijo_Permisos);
            this.GroupBox_APermisos_Permisos.Controls.Add(this.lstDisponibles);
            this.GroupBox_APermisos_Permisos.Location = new System.Drawing.Point(402, 171);
            this.GroupBox_APermisos_Permisos.Name = "GroupBox_APermisos_Permisos";
            this.GroupBox_APermisos_Permisos.Size = new System.Drawing.Size(358, 267);
            this.GroupBox_APermisos_Permisos.TabIndex = 2;
            this.GroupBox_APermisos_Permisos.TabStop = false;
            this.GroupBox_APermisos_Permisos.Text = "Asignar";
            // 
            // Btn_Refrescar_Permisos
            // 
            this.Btn_Refrescar_Permisos.Location = new System.Drawing.Point(158, 73);
            this.Btn_Refrescar_Permisos.Name = "Btn_Refrescar_Permisos";
            this.Btn_Refrescar_Permisos.Size = new System.Drawing.Size(194, 37);
            this.Btn_Refrescar_Permisos.TabIndex = 9;
            this.Btn_Refrescar_Permisos.Text = "Refrescar";
            this.Btn_Refrescar_Permisos.UseVisualStyleBackColor = true;
            this.Btn_Refrescar_Permisos.Click += new System.EventHandler(this.BtnRefrescar_Click);
            // 
            // Btn_QuitarNodo_Permisos
            // 
            this.Btn_QuitarNodo_Permisos.Location = new System.Drawing.Point(158, 230);
            this.Btn_QuitarNodo_Permisos.Name = "Btn_QuitarNodo_Permisos";
            this.Btn_QuitarNodo_Permisos.Size = new System.Drawing.Size(194, 28);
            this.Btn_QuitarNodo_Permisos.TabIndex = 8;
            this.Btn_QuitarNodo_Permisos.Text = "Quitar";
            this.Btn_QuitarNodo_Permisos.UseVisualStyleBackColor = true;
            this.Btn_QuitarNodo_Permisos.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // Btn_AgregarHijo_Permisos
            // 
            this.Btn_AgregarHijo_Permisos.Location = new System.Drawing.Point(158, 20);
            this.Btn_AgregarHijo_Permisos.Name = "Btn_AgregarHijo_Permisos";
            this.Btn_AgregarHijo_Permisos.Size = new System.Drawing.Size(194, 47);
            this.Btn_AgregarHijo_Permisos.TabIndex = 7;
            this.Btn_AgregarHijo_Permisos.Text = "Agregar";
            this.Btn_AgregarHijo_Permisos.UseVisualStyleBackColor = true;
            this.Btn_AgregarHijo_Permisos.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // lstDisponibles
            // 
            this.lstDisponibles.FormattingEnabled = true;
            this.lstDisponibles.Location = new System.Drawing.Point(7, 20);
            this.lstDisponibles.Name = "lstDisponibles";
            this.lstDisponibles.Size = new System.Drawing.Size(145, 238);
            this.lstDisponibles.TabIndex = 0;
            // 
            // frmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 442);
            this.Controls.Add(this.GroupBox_APermisos_Permisos);
            this.Controls.Add(this.treePermisos);
            this.Controls.Add(this.GroupBox_NPermisos_Permisos);
            this.MaximumSize = new System.Drawing.Size(784, 481);
            this.MinimumSize = new System.Drawing.Size(784, 481);
            this.Name = "frmPermisos";
            this.Text = "Permisos";
            this.Load += new System.EventHandler(this.frmPermisos_Load);
            this.GroupBox_NPermisos_Permisos.ResumeLayout(false);
            this.GroupBox_NPermisos_Permisos.PerformLayout();
            this.GroupBox_APermisos_Permisos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_NPermisos_Permisos;
        private System.Windows.Forms.Label Lbl_Nombre_Permisos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button BtnCrear_Crear_Permisos;
        private System.Windows.Forms.RadioButton Rb_Familia_Permisos;
        private System.Windows.Forms.RadioButton Rb_Patente_Permisos;
        private System.Windows.Forms.Label Lbl_Descripcion_Permisos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TreeView treePermisos;
        private System.Windows.Forms.GroupBox GroupBox_APermisos_Permisos;
        private System.Windows.Forms.Button Btn_Refrescar_Permisos;
        private System.Windows.Forms.Button Btn_QuitarNodo_Permisos;
        private System.Windows.Forms.Button Btn_AgregarHijo_Permisos;
        private System.Windows.Forms.ListBox lstDisponibles;
    }
}
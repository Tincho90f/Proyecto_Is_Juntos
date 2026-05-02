namespace Proyecto_Is_Juntos
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NombreUsuario_Textbox = new System.Windows.Forms.TextBox();
            this.Password_Textbox = new System.Windows.Forms.TextBox();
            this.Btn_IniciarSesion_Login = new System.Windows.Forms.Button();
            this.Lbl_Nombre_Login = new System.Windows.Forms.Label();
            this.Lbl_Contraseña_Login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NombreUsuario_Textbox
            // 
            this.NombreUsuario_Textbox.Location = new System.Drawing.Point(79, 6);
            this.NombreUsuario_Textbox.Name = "NombreUsuario_Textbox";
            this.NombreUsuario_Textbox.Size = new System.Drawing.Size(182, 20);
            this.NombreUsuario_Textbox.TabIndex = 0;
            // 
            // Password_Textbox
            // 
            this.Password_Textbox.Location = new System.Drawing.Point(79, 39);
            this.Password_Textbox.Name = "Password_Textbox";
            this.Password_Textbox.PasswordChar = '*';
            this.Password_Textbox.Size = new System.Drawing.Size(182, 20);
            this.Password_Textbox.TabIndex = 1;
            this.Password_Textbox.UseSystemPasswordChar = true;
            // 
            // Btn_IniciarSesion_Login
            // 
            this.Btn_IniciarSesion_Login.Location = new System.Drawing.Point(15, 65);
            this.Btn_IniciarSesion_Login.Name = "Btn_IniciarSesion_Login";
            this.Btn_IniciarSesion_Login.Size = new System.Drawing.Size(246, 27);
            this.Btn_IniciarSesion_Login.TabIndex = 2;
            this.Btn_IniciarSesion_Login.Text = "Iniciar Sesión";
            this.Btn_IniciarSesion_Login.UseVisualStyleBackColor = true;
            this.Btn_IniciarSesion_Login.Click += new System.EventHandler(this.btn_IniciarSesion_Click);
            // 
            // Lbl_Nombre_Login
            // 
            this.Lbl_Nombre_Login.AutoSize = true;
            this.Lbl_Nombre_Login.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Nombre_Login.Name = "Lbl_Nombre_Login";
            this.Lbl_Nombre_Login.Size = new System.Drawing.Size(44, 13);
            this.Lbl_Nombre_Login.TabIndex = 3;
            this.Lbl_Nombre_Login.Text = "Nombre";
            // 
            // Lbl_Contraseña_Login
            // 
            this.Lbl_Contraseña_Login.AutoSize = true;
            this.Lbl_Contraseña_Login.Location = new System.Drawing.Point(12, 42);
            this.Lbl_Contraseña_Login.Name = "Lbl_Contraseña_Login";
            this.Lbl_Contraseña_Login.Size = new System.Drawing.Size(61, 13);
            this.Lbl_Contraseña_Login.TabIndex = 4;
            this.Lbl_Contraseña_Login.Text = "Contraseña";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 105);
            this.Controls.Add(this.Lbl_Contraseña_Login);
            this.Controls.Add(this.Lbl_Nombre_Login);
            this.Controls.Add(this.Btn_IniciarSesion_Login);
            this.Controls.Add(this.Password_Textbox);
            this.Controls.Add(this.NombreUsuario_Textbox);
            this.MaximumSize = new System.Drawing.Size(302, 144);
            this.MinimumSize = new System.Drawing.Size(302, 144);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing_1);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreUsuario_Textbox;
        private System.Windows.Forms.TextBox Password_Textbox;
        private System.Windows.Forms.Button Btn_IniciarSesion_Login;
        private System.Windows.Forms.Label Lbl_Nombre_Login;
        private System.Windows.Forms.Label Lbl_Contraseña_Login;
    }
}


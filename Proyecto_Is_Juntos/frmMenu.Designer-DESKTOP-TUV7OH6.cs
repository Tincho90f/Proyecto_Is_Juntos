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
            this.btn_Bitacora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.Location = new System.Drawing.Point(406, 217);
            this.btn_CerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(130, 32);
            this.btn_CerrarSesion.TabIndex = 0;
            this.btn_CerrarSesion.Text = "Cerrar Sesión";
            this.btn_CerrarSesion.UseVisualStyleBackColor = true;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.btn_CerrarSesion_Click);
            // 
            // btn_Bitacora
            // 
            this.btn_Bitacora.Location = new System.Drawing.Point(12, 12);
            this.btn_Bitacora.Name = "btn_Bitacora";
            this.btn_Bitacora.Size = new System.Drawing.Size(523, 39);
            this.btn_Bitacora.TabIndex = 1;
            this.btn_Bitacora.Text = "Bitacora";
            this.btn_Bitacora.UseVisualStyleBackColor = true;
            this.btn_Bitacora.Click += new System.EventHandler(this.btn_Bitacora_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 260);
            this.Controls.Add(this.btn_Bitacora);
            this.Controls.Add(this.btn_CerrarSesion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CerrarSesion;
        private System.Windows.Forms.Button btn_Bitacora;
    }
}
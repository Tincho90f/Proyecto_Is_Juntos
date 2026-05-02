namespace Proyecto_Is_Juntos
{
    partial class frmIdioma
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
            this.Btn_CambiarIdioma_Idioma = new System.Windows.Forms.Button();
            this.ComboBox_SeleccionIdioma_Idioma = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Btn_CambiarIdioma_Idioma
            // 
            this.Btn_CambiarIdioma_Idioma.Location = new System.Drawing.Point(268, 16);
            this.Btn_CambiarIdioma_Idioma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_CambiarIdioma_Idioma.Name = "Btn_CambiarIdioma_Idioma";
            this.Btn_CambiarIdioma_Idioma.Size = new System.Drawing.Size(251, 36);
            this.Btn_CambiarIdioma_Idioma.TabIndex = 2;
            this.Btn_CambiarIdioma_Idioma.Text = "Cambiar Idioma";
            this.Btn_CambiarIdioma_Idioma.UseVisualStyleBackColor = true;
            this.Btn_CambiarIdioma_Idioma.Click += new System.EventHandler(this.btn_CambiarIdioma_Idioma_Click);
            // 
            // ComboBox_SeleccionIdioma_Idioma
            // 
            this.ComboBox_SeleccionIdioma_Idioma.FormattingEnabled = true;
            this.ComboBox_SeleccionIdioma_Idioma.Location = new System.Drawing.Point(12, 23);
            this.ComboBox_SeleccionIdioma_Idioma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBox_SeleccionIdioma_Idioma.Name = "ComboBox_SeleccionIdioma_Idioma";
            this.ComboBox_SeleccionIdioma_Idioma.Size = new System.Drawing.Size(249, 24);
            this.ComboBox_SeleccionIdioma_Idioma.TabIndex = 4;
            // 
            // frmIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 69);
            this.Controls.Add(this.ComboBox_SeleccionIdioma_Idioma);
            this.Controls.Add(this.Btn_CambiarIdioma_Idioma);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(555, 116);
            this.MinimumSize = new System.Drawing.Size(555, 116);
            this.Name = "frmIdioma";
            this.Text = "Idioma";
            this.Load += new System.EventHandler(this.frmIdioma_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_CambiarIdioma_Idioma;
        private System.Windows.Forms.ComboBox ComboBox_SeleccionIdioma_Idioma;
    }
}
namespace Proyecto_Is_Juntos
{
    partial class frmBitacora
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
            this.Btn_Cargar_Bitacora = new System.Windows.Forms.Button();
            this.DataGridView_Bitacora = new System.Windows.Forms.DataGridView();
            this.Lbl_Usuario_Bitacora = new System.Windows.Forms.Label();
            this.Lbl_TipoDeOperacion_Bitacora = new System.Windows.Forms.Label();
            this.ComboBox_TipoDeOperacion_Bitacora = new System.Windows.Forms.ComboBox();
            this.Lbl_IDOperacion_Bitacora = new System.Windows.Forms.Label();
            this.DateTime_Bitacora = new System.Windows.Forms.DateTimePicker();
            this.Lbl_FechaDeLaOperacion_Bitacora = new System.Windows.Forms.Label();
            this.Txt_IDOperacion_Bitacora = new System.Windows.Forms.TextBox();
            this.Txt_Usuario_Bitacora = new System.Windows.Forms.TextBox();
            this.chechkBox_Fecha_Bitacora = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Bitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Cargar_Bitacora
            // 
            this.Btn_Cargar_Bitacora.Location = new System.Drawing.Point(91, 12);
            this.Btn_Cargar_Bitacora.Name = "Btn_Cargar_Bitacora";
            this.Btn_Cargar_Bitacora.Size = new System.Drawing.Size(678, 34);
            this.Btn_Cargar_Bitacora.TabIndex = 0;
            this.Btn_Cargar_Bitacora.Text = "Cargar Bitacora";
            this.Btn_Cargar_Bitacora.UseVisualStyleBackColor = true;
            this.Btn_Cargar_Bitacora.Click += new System.EventHandler(this.btn_CargarBitacora_Click);
            // 
            // DataGridView_Bitacora
            // 
            this.DataGridView_Bitacora.AllowUserToAddRows = false;
            this.DataGridView_Bitacora.AllowUserToDeleteRows = false;
            this.DataGridView_Bitacora.AllowUserToResizeColumns = false;
            this.DataGridView_Bitacora.AllowUserToResizeRows = false;
            this.DataGridView_Bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Bitacora.Location = new System.Drawing.Point(11, 120);
            this.DataGridView_Bitacora.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView_Bitacora.Name = "DataGridView_Bitacora";
            this.DataGridView_Bitacora.ReadOnly = true;
            this.DataGridView_Bitacora.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataGridView_Bitacora.RowTemplate.Height = 24;
            this.DataGridView_Bitacora.Size = new System.Drawing.Size(838, 319);
            this.DataGridView_Bitacora.TabIndex = 1;
            // 
            // Lbl_Usuario_Bitacora
            // 
            this.Lbl_Usuario_Bitacora.AutoSize = true;
            this.Lbl_Usuario_Bitacora.Location = new System.Drawing.Point(689, 57);
            this.Lbl_Usuario_Bitacora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Usuario_Bitacora.Name = "Lbl_Usuario_Bitacora";
            this.Lbl_Usuario_Bitacora.Size = new System.Drawing.Size(43, 13);
            this.Lbl_Usuario_Bitacora.TabIndex = 3;
            this.Lbl_Usuario_Bitacora.Text = "Usuario";
            // 
            // Lbl_TipoDeOperacion_Bitacora
            // 
            this.Lbl_TipoDeOperacion_Bitacora.AutoSize = true;
            this.Lbl_TipoDeOperacion_Bitacora.Location = new System.Drawing.Point(261, 57);
            this.Lbl_TipoDeOperacion_Bitacora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_TipoDeOperacion_Bitacora.Name = "Lbl_TipoDeOperacion_Bitacora";
            this.Lbl_TipoDeOperacion_Bitacora.Size = new System.Drawing.Size(95, 13);
            this.Lbl_TipoDeOperacion_Bitacora.TabIndex = 5;
            this.Lbl_TipoDeOperacion_Bitacora.Text = "Tipo de Operación";
            // 
            // ComboBox_TipoDeOperacion_Bitacora
            // 
            this.ComboBox_TipoDeOperacion_Bitacora.FormattingEnabled = true;
            this.ComboBox_TipoDeOperacion_Bitacora.Location = new System.Drawing.Point(250, 77);
            this.ComboBox_TipoDeOperacion_Bitacora.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox_TipoDeOperacion_Bitacora.Name = "ComboBox_TipoDeOperacion_Bitacora";
            this.ComboBox_TipoDeOperacion_Bitacora.Size = new System.Drawing.Size(117, 21);
            this.ComboBox_TipoDeOperacion_Bitacora.TabIndex = 4;
            // 
            // Lbl_IDOperacion_Bitacora
            // 
            this.Lbl_IDOperacion_Bitacora.AutoSize = true;
            this.Lbl_IDOperacion_Bitacora.Location = new System.Drawing.Point(113, 57);
            this.Lbl_IDOperacion_Bitacora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_IDOperacion_Bitacora.Name = "Lbl_IDOperacion_Bitacora";
            this.Lbl_IDOperacion_Bitacora.Size = new System.Drawing.Size(70, 13);
            this.Lbl_IDOperacion_Bitacora.TabIndex = 7;
            this.Lbl_IDOperacion_Bitacora.Text = "ID Operación";
            // 
            // DateTime_Bitacora
            // 
            this.DateTime_Bitacora.Location = new System.Drawing.Point(405, 77);
            this.DateTime_Bitacora.Margin = new System.Windows.Forms.Padding(2);
            this.DateTime_Bitacora.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.DateTime_Bitacora.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.DateTime_Bitacora.Name = "DateTime_Bitacora";
            this.DateTime_Bitacora.Size = new System.Drawing.Size(201, 20);
            this.DateTime_Bitacora.TabIndex = 9;
            // 
            // Lbl_FechaDeLaOperacion_Bitacora
            // 
            this.Lbl_FechaDeLaOperacion_Bitacora.AutoSize = true;
            this.Lbl_FechaDeLaOperacion_Bitacora.Location = new System.Drawing.Point(450, 57);
            this.Lbl_FechaDeLaOperacion_Bitacora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_FechaDeLaOperacion_Bitacora.Name = "Lbl_FechaDeLaOperacion_Bitacora";
            this.Lbl_FechaDeLaOperacion_Bitacora.Size = new System.Drawing.Size(115, 13);
            this.Lbl_FechaDeLaOperacion_Bitacora.TabIndex = 10;
            this.Lbl_FechaDeLaOperacion_Bitacora.Text = "Fecha de la Operacion";
            // 
            // Txt_IDOperacion_Bitacora
            // 
            this.Txt_IDOperacion_Bitacora.Location = new System.Drawing.Point(91, 77);
            this.Txt_IDOperacion_Bitacora.Name = "Txt_IDOperacion_Bitacora";
            this.Txt_IDOperacion_Bitacora.Size = new System.Drawing.Size(117, 20);
            this.Txt_IDOperacion_Bitacora.TabIndex = 11;
            // 
            // Txt_Usuario_Bitacora
            // 
            this.Txt_Usuario_Bitacora.Location = new System.Drawing.Point(652, 77);
            this.Txt_Usuario_Bitacora.Name = "Txt_Usuario_Bitacora";
            this.Txt_Usuario_Bitacora.Size = new System.Drawing.Size(117, 20);
            this.Txt_Usuario_Bitacora.TabIndex = 12;
            // 
            // chechkBox_Fecha_Bitacora
            // 
            this.chechkBox_Fecha_Bitacora.AutoSize = true;
            this.chechkBox_Fecha_Bitacora.Location = new System.Drawing.Point(387, 80);
            this.chechkBox_Fecha_Bitacora.Margin = new System.Windows.Forms.Padding(2);
            this.chechkBox_Fecha_Bitacora.Name = "chechkBox_Fecha_Bitacora";
            this.chechkBox_Fecha_Bitacora.Size = new System.Drawing.Size(15, 14);
            this.chechkBox_Fecha_Bitacora.TabIndex = 13;
            this.chechkBox_Fecha_Bitacora.UseVisualStyleBackColor = true;
            this.chechkBox_Fecha_Bitacora.CheckedChanged += new System.EventHandler(this.chechkBox_Fecha_Bitacora_CheckedChanged);
            // 
            // frmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.chechkBox_Fecha_Bitacora);
            this.Controls.Add(this.Txt_Usuario_Bitacora);
            this.Controls.Add(this.Txt_IDOperacion_Bitacora);
            this.Controls.Add(this.Lbl_FechaDeLaOperacion_Bitacora);
            this.Controls.Add(this.DateTime_Bitacora);
            this.Controls.Add(this.Lbl_IDOperacion_Bitacora);
            this.Controls.Add(this.Lbl_TipoDeOperacion_Bitacora);
            this.Controls.Add(this.ComboBox_TipoDeOperacion_Bitacora);
            this.Controls.Add(this.Lbl_Usuario_Bitacora);
            this.Controls.Add(this.DataGridView_Bitacora);
            this.Controls.Add(this.Btn_Cargar_Bitacora);
            this.Name = "frmBitacora";
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.frmBitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Bitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cargar_Bitacora;
        private System.Windows.Forms.DataGridView DataGridView_Bitacora;
        private System.Windows.Forms.Label Lbl_Usuario_Bitacora;
        private System.Windows.Forms.Label Lbl_TipoDeOperacion_Bitacora;
        private System.Windows.Forms.ComboBox ComboBox_TipoDeOperacion_Bitacora;
        private System.Windows.Forms.Label Lbl_IDOperacion_Bitacora;
        private System.Windows.Forms.DateTimePicker DateTime_Bitacora;
        private System.Windows.Forms.Label Lbl_FechaDeLaOperacion_Bitacora;
        private System.Windows.Forms.TextBox Txt_IDOperacion_Bitacora;
        private System.Windows.Forms.TextBox Txt_Usuario_Bitacora;
        private System.Windows.Forms.CheckBox chechkBox_Fecha_Bitacora;
    }
}
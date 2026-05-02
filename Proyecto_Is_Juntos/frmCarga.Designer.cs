namespace Proyecto_Is_Juntos
{
    partial class frmCargaModificacion
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
            this.Btn_AceptarProducto_CargaModificacion = new System.Windows.Forms.Button();
            this.Txt_NombreProducto_CargaModificacion = new System.Windows.Forms.TextBox();
            this.Txt_PrecioProducto_CargaModificacion = new System.Windows.Forms.TextBox();
            this.groupBox_Carga = new System.Windows.Forms.GroupBox();
            this.Lbl_PrecioProducto_CargaModificacion = new System.Windows.Forms.Label();
            this.Lbl_NombreProducto_CargaModificacion = new System.Windows.Forms.Label();
            this.DataGridView_Productos_CargaModificacion = new System.Windows.Forms.DataGridView();
            this.groupBox_Modificacion = new System.Windows.Forms.GroupBox();
            this.Lbl_PrecioModificacion_CargaModificacion = new System.Windows.Forms.Label();
            this.Lbl_NombreModificacion_CargaModificacion = new System.Windows.Forms.Label();
            this.Btn_AceptarModificacion_CargaModificacion = new System.Windows.Forms.Button();
            this.Txt_PrecioModificacion_CargaModificacion = new System.Windows.Forms.TextBox();
            this.Txt_NombreModificacion_CargaModificacion = new System.Windows.Forms.TextBox();
            this.groupBox_Carga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Productos_CargaModificacion)).BeginInit();
            this.groupBox_Modificacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_AceptarProducto_CargaModificacion
            // 
            this.Btn_AceptarProducto_CargaModificacion.Location = new System.Drawing.Point(12, 100);
            this.Btn_AceptarProducto_CargaModificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_AceptarProducto_CargaModificacion.Name = "Btn_AceptarProducto_CargaModificacion";
            this.Btn_AceptarProducto_CargaModificacion.Size = new System.Drawing.Size(256, 28);
            this.Btn_AceptarProducto_CargaModificacion.TabIndex = 0;
            this.Btn_AceptarProducto_CargaModificacion.Text = "Aceptar";
            this.Btn_AceptarProducto_CargaModificacion.UseVisualStyleBackColor = true;
            this.Btn_AceptarProducto_CargaModificacion.Click += new System.EventHandler(this.btn_Aceptar_Carga_Click);
            // 
            // Txt_NombreProducto_CargaModificacion
            // 
            this.Txt_NombreProducto_CargaModificacion.Location = new System.Drawing.Point(75, 21);
            this.Txt_NombreProducto_CargaModificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_NombreProducto_CargaModificacion.Name = "Txt_NombreProducto_CargaModificacion";
            this.Txt_NombreProducto_CargaModificacion.Size = new System.Drawing.Size(193, 22);
            this.Txt_NombreProducto_CargaModificacion.TabIndex = 1;
            // 
            // Txt_PrecioProducto_CargaModificacion
            // 
            this.Txt_PrecioProducto_CargaModificacion.Location = new System.Drawing.Point(75, 55);
            this.Txt_PrecioProducto_CargaModificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_PrecioProducto_CargaModificacion.Name = "Txt_PrecioProducto_CargaModificacion";
            this.Txt_PrecioProducto_CargaModificacion.Size = new System.Drawing.Size(193, 22);
            this.Txt_PrecioProducto_CargaModificacion.TabIndex = 2;
            this.Txt_PrecioProducto_CargaModificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_PrecioProducto_CargaModificacion_KeyPress);
            // 
            // groupBox_Carga
            // 
            this.groupBox_Carga.Controls.Add(this.Lbl_PrecioProducto_CargaModificacion);
            this.groupBox_Carga.Controls.Add(this.Lbl_NombreProducto_CargaModificacion);
            this.groupBox_Carga.Controls.Add(this.Btn_AceptarProducto_CargaModificacion);
            this.groupBox_Carga.Controls.Add(this.Txt_PrecioProducto_CargaModificacion);
            this.groupBox_Carga.Controls.Add(this.Txt_NombreProducto_CargaModificacion);
            this.groupBox_Carga.Location = new System.Drawing.Point(16, 15);
            this.groupBox_Carga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Carga.Name = "groupBox_Carga";
            this.groupBox_Carga.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Carga.Size = new System.Drawing.Size(276, 135);
            this.groupBox_Carga.TabIndex = 3;
            this.groupBox_Carga.TabStop = false;
            this.groupBox_Carga.Text = "Carga";
            // 
            // Lbl_PrecioProducto_CargaModificacion
            // 
            this.Lbl_PrecioProducto_CargaModificacion.AutoSize = true;
            this.Lbl_PrecioProducto_CargaModificacion.Location = new System.Drawing.Point(8, 59);
            this.Lbl_PrecioProducto_CargaModificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_PrecioProducto_CargaModificacion.Name = "Lbl_PrecioProducto_CargaModificacion";
            this.Lbl_PrecioProducto_CargaModificacion.Size = new System.Drawing.Size(46, 16);
            this.Lbl_PrecioProducto_CargaModificacion.TabIndex = 4;
            this.Lbl_PrecioProducto_CargaModificacion.Text = "Precio";
            // 
            // Lbl_NombreProducto_CargaModificacion
            // 
            this.Lbl_NombreProducto_CargaModificacion.AutoSize = true;
            this.Lbl_NombreProducto_CargaModificacion.Location = new System.Drawing.Point(8, 25);
            this.Lbl_NombreProducto_CargaModificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_NombreProducto_CargaModificacion.Name = "Lbl_NombreProducto_CargaModificacion";
            this.Lbl_NombreProducto_CargaModificacion.Size = new System.Drawing.Size(56, 16);
            this.Lbl_NombreProducto_CargaModificacion.TabIndex = 3;
            this.Lbl_NombreProducto_CargaModificacion.Text = "Nombre";
            // 
            // DataGridView_Productos_CargaModificacion
            // 
            this.DataGridView_Productos_CargaModificacion.AllowUserToAddRows = false;
            this.DataGridView_Productos_CargaModificacion.AllowUserToDeleteRows = false;
            this.DataGridView_Productos_CargaModificacion.AllowUserToResizeColumns = false;
            this.DataGridView_Productos_CargaModificacion.AllowUserToResizeRows = false;
            this.DataGridView_Productos_CargaModificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Productos_CargaModificacion.Location = new System.Drawing.Point(300, 15);
            this.DataGridView_Productos_CargaModificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridView_Productos_CargaModificacion.MaximumSize = new System.Drawing.Size(510, 334);
            this.DataGridView_Productos_CargaModificacion.MinimumSize = new System.Drawing.Size(510, 334);
            this.DataGridView_Productos_CargaModificacion.MultiSelect = false;
            this.DataGridView_Productos_CargaModificacion.Name = "DataGridView_Productos_CargaModificacion";
            this.DataGridView_Productos_CargaModificacion.ReadOnly = true;
            this.DataGridView_Productos_CargaModificacion.RowHeadersWidth = 51;
            this.DataGridView_Productos_CargaModificacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Productos_CargaModificacion.Size = new System.Drawing.Size(510, 334);
            this.DataGridView_Productos_CargaModificacion.TabIndex = 4;
            this.DataGridView_Productos_CargaModificacion.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_CargaModificacion_RowHeaderMouseDoubleClick);
            // 
            // groupBox_Modificacion
            // 
            this.groupBox_Modificacion.Controls.Add(this.Lbl_PrecioModificacion_CargaModificacion);
            this.groupBox_Modificacion.Controls.Add(this.Lbl_NombreModificacion_CargaModificacion);
            this.groupBox_Modificacion.Controls.Add(this.Btn_AceptarModificacion_CargaModificacion);
            this.groupBox_Modificacion.Controls.Add(this.Txt_PrecioModificacion_CargaModificacion);
            this.groupBox_Modificacion.Controls.Add(this.Txt_NombreModificacion_CargaModificacion);
            this.groupBox_Modificacion.Location = new System.Drawing.Point(16, 209);
            this.groupBox_Modificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Modificacion.Name = "groupBox_Modificacion";
            this.groupBox_Modificacion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Modificacion.Size = new System.Drawing.Size(276, 135);
            this.groupBox_Modificacion.TabIndex = 5;
            this.groupBox_Modificacion.TabStop = false;
            this.groupBox_Modificacion.Text = "Modificación";
            // 
            // Lbl_PrecioModificacion_CargaModificacion
            // 
            this.Lbl_PrecioModificacion_CargaModificacion.AutoSize = true;
            this.Lbl_PrecioModificacion_CargaModificacion.Location = new System.Drawing.Point(8, 59);
            this.Lbl_PrecioModificacion_CargaModificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_PrecioModificacion_CargaModificacion.Name = "Lbl_PrecioModificacion_CargaModificacion";
            this.Lbl_PrecioModificacion_CargaModificacion.Size = new System.Drawing.Size(46, 16);
            this.Lbl_PrecioModificacion_CargaModificacion.TabIndex = 4;
            this.Lbl_PrecioModificacion_CargaModificacion.Text = "Precio";
            // 
            // Lbl_NombreModificacion_CargaModificacion
            // 
            this.Lbl_NombreModificacion_CargaModificacion.AutoSize = true;
            this.Lbl_NombreModificacion_CargaModificacion.Location = new System.Drawing.Point(8, 25);
            this.Lbl_NombreModificacion_CargaModificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_NombreModificacion_CargaModificacion.Name = "Lbl_NombreModificacion_CargaModificacion";
            this.Lbl_NombreModificacion_CargaModificacion.Size = new System.Drawing.Size(56, 16);
            this.Lbl_NombreModificacion_CargaModificacion.TabIndex = 3;
            this.Lbl_NombreModificacion_CargaModificacion.Text = "Nombre";
            // 
            // Btn_AceptarModificacion_CargaModificacion
            // 
            this.Btn_AceptarModificacion_CargaModificacion.Location = new System.Drawing.Point(12, 100);
            this.Btn_AceptarModificacion_CargaModificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_AceptarModificacion_CargaModificacion.Name = "Btn_AceptarModificacion_CargaModificacion";
            this.Btn_AceptarModificacion_CargaModificacion.Size = new System.Drawing.Size(256, 28);
            this.Btn_AceptarModificacion_CargaModificacion.TabIndex = 0;
            this.Btn_AceptarModificacion_CargaModificacion.Text = "Aceptar Modificacion";
            this.Btn_AceptarModificacion_CargaModificacion.UseVisualStyleBackColor = true;
            this.Btn_AceptarModificacion_CargaModificacion.Click += new System.EventHandler(this.btn_AceptarModificacion_CargaModificacion_Click);
            // 
            // Txt_PrecioModificacion_CargaModificacion
            // 
            this.Txt_PrecioModificacion_CargaModificacion.Location = new System.Drawing.Point(75, 55);
            this.Txt_PrecioModificacion_CargaModificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_PrecioModificacion_CargaModificacion.Name = "Txt_PrecioModificacion_CargaModificacion";
            this.Txt_PrecioModificacion_CargaModificacion.Size = new System.Drawing.Size(193, 22);
            this.Txt_PrecioModificacion_CargaModificacion.TabIndex = 2;
            this.Txt_PrecioModificacion_CargaModificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_PrecioModificacion_CargaModificacion_KeyPress);
            // 
            // Txt_NombreModificacion_CargaModificacion
            // 
            this.Txt_NombreModificacion_CargaModificacion.Location = new System.Drawing.Point(75, 21);
            this.Txt_NombreModificacion_CargaModificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_NombreModificacion_CargaModificacion.Name = "Txt_NombreModificacion_CargaModificacion";
            this.Txt_NombreModificacion_CargaModificacion.ReadOnly = true;
            this.Txt_NombreModificacion_CargaModificacion.Size = new System.Drawing.Size(193, 22);
            this.Txt_NombreModificacion_CargaModificacion.TabIndex = 1;
            // 
            // frmCargaModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 358);
            this.Controls.Add(this.groupBox_Modificacion);
            this.Controls.Add(this.DataGridView_Productos_CargaModificacion);
            this.Controls.Add(this.groupBox_Carga);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCargaModificacion";
            this.ShowInTaskbar = false;
            this.Text = "Carga/Modificacion De Productos";
            this.Load += new System.EventHandler(this.frmCarga_Load);
            this.groupBox_Carga.ResumeLayout(false);
            this.groupBox_Carga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Productos_CargaModificacion)).EndInit();
            this.groupBox_Modificacion.ResumeLayout(false);
            this.groupBox_Modificacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_AceptarProducto_CargaModificacion;
        private System.Windows.Forms.TextBox Txt_NombreProducto_CargaModificacion;
        private System.Windows.Forms.TextBox Txt_PrecioProducto_CargaModificacion;
        private System.Windows.Forms.GroupBox groupBox_Carga;
        private System.Windows.Forms.Label Lbl_PrecioProducto_CargaModificacion;
        private System.Windows.Forms.Label Lbl_NombreProducto_CargaModificacion;
        private System.Windows.Forms.DataGridView DataGridView_Productos_CargaModificacion;
        private System.Windows.Forms.GroupBox groupBox_Modificacion;
        private System.Windows.Forms.Label Lbl_PrecioModificacion_CargaModificacion;
        private System.Windows.Forms.Label Lbl_NombreModificacion_CargaModificacion;
        private System.Windows.Forms.Button Btn_AceptarModificacion_CargaModificacion;
        private System.Windows.Forms.TextBox Txt_PrecioModificacion_CargaModificacion;
        private System.Windows.Forms.TextBox Txt_NombreModificacion_CargaModificacion;
    }
}
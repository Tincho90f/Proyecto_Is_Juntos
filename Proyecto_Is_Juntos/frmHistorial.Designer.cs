namespace Proyecto_Is_Juntos
{
    partial class frmHistorial
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
            this.DataGridView_Productos_Historial = new System.Windows.Forms.DataGridView();
            this.DataGridView_ModificacionesProducto_Historial = new System.Windows.Forms.DataGridView();
            this.Lbl_Seleccionar_Historial = new System.Windows.Forms.Label();
            this.Btn_RetornarModificacion_Historial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Productos_Historial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ModificacionesProducto_Historial)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_Productos_Historial
            // 
            this.DataGridView_Productos_Historial.AllowUserToAddRows = false;
            this.DataGridView_Productos_Historial.AllowUserToDeleteRows = false;
            this.DataGridView_Productos_Historial.AllowUserToResizeColumns = false;
            this.DataGridView_Productos_Historial.AllowUserToResizeRows = false;
            this.DataGridView_Productos_Historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Productos_Historial.Location = new System.Drawing.Point(12, 47);
            this.DataGridView_Productos_Historial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridView_Productos_Historial.MultiSelect = false;
            this.DataGridView_Productos_Historial.Name = "DataGridView_Productos_Historial";
            this.DataGridView_Productos_Historial.ReadOnly = true;
            this.DataGridView_Productos_Historial.RowHeadersWidth = 51;
            this.DataGridView_Productos_Historial.RowTemplate.Height = 24;
            this.DataGridView_Productos_Historial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Productos_Historial.Size = new System.Drawing.Size(473, 391);
            this.DataGridView_Productos_Historial.TabIndex = 1;
            this.DataGridView_Productos_Historial.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_Productos_Historial_RowHeaderMouseDoubleClick);
            // 
            // DataGridView_ModificacionesProducto_Historial
            // 
            this.DataGridView_ModificacionesProducto_Historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ModificacionesProducto_Historial.Location = new System.Drawing.Point(541, 47);
            this.DataGridView_ModificacionesProducto_Historial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridView_ModificacionesProducto_Historial.MultiSelect = false;
            this.DataGridView_ModificacionesProducto_Historial.Name = "DataGridView_ModificacionesProducto_Historial";
            this.DataGridView_ModificacionesProducto_Historial.ReadOnly = true;
            this.DataGridView_ModificacionesProducto_Historial.RowHeadersWidth = 51;
            this.DataGridView_ModificacionesProducto_Historial.RowTemplate.Height = 24;
            this.DataGridView_ModificacionesProducto_Historial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_ModificacionesProducto_Historial.Size = new System.Drawing.Size(787, 391);
            this.DataGridView_ModificacionesProducto_Historial.TabIndex = 2;
            // 
            // Lbl_Seleccionar_Historial
            // 
            this.Lbl_Seleccionar_Historial.AutoSize = true;
            this.Lbl_Seleccionar_Historial.Location = new System.Drawing.Point(109, 16);
            this.Lbl_Seleccionar_Historial.Name = "Lbl_Seleccionar_Historial";
            this.Lbl_Seleccionar_Historial.Size = new System.Drawing.Size(268, 16);
            this.Lbl_Seleccionar_Historial.TabIndex = 3;
            this.Lbl_Seleccionar_Historial.Text = "Seleccionar el producto para ver su historial";
            // 
            // Btn_RetornarModificacion_Historial
            // 
            this.Btn_RetornarModificacion_Historial.Location = new System.Drawing.Point(651, 6);
            this.Btn_RetornarModificacion_Historial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_RetornarModificacion_Historial.Name = "Btn_RetornarModificacion_Historial";
            this.Btn_RetornarModificacion_Historial.Size = new System.Drawing.Size(567, 37);
            this.Btn_RetornarModificacion_Historial.TabIndex = 4;
            this.Btn_RetornarModificacion_Historial.Text = "Retornar Cambio";
            this.Btn_RetornarModificacion_Historial.UseVisualStyleBackColor = true;
            this.Btn_RetornarModificacion_Historial.Click += new System.EventHandler(this.Btn_RetornarModificacion_Historial_Click);
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 448);
            this.Controls.Add(this.Btn_RetornarModificacion_Historial);
            this.Controls.Add(this.Lbl_Seleccionar_Historial);
            this.Controls.Add(this.DataGridView_ModificacionesProducto_Historial);
            this.Controls.Add(this.DataGridView_Productos_Historial);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1358, 495);
            this.MinimumSize = new System.Drawing.Size(1358, 495);
            this.Name = "frmHistorial";
            this.Text = "Historial de Productos";
            this.Load += new System.EventHandler(this.frmHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Productos_Historial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ModificacionesProducto_Historial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridView_Productos_Historial;
        private System.Windows.Forms.DataGridView DataGridView_ModificacionesProducto_Historial;
        private System.Windows.Forms.Label Lbl_Seleccionar_Historial;
        private System.Windows.Forms.Button Btn_RetornarModificacion_Historial;
    }
}
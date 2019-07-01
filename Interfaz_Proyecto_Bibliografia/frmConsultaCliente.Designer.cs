namespace Interfaz_Proyecto_Bibliografia
{
    partial class frmConsultaCliente
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.rdbNroDocumento = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.dtgDetalleClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(238, 90);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(250, 41);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(145, 20);
            this.txtValor.TabIndex = 1;
            // 
            // rdbNroDocumento
            // 
            this.rdbNroDocumento.AutoSize = true;
            this.rdbNroDocumento.Location = new System.Drawing.Point(24, 28);
            this.rdbNroDocumento.Name = "rdbNroDocumento";
            this.rdbNroDocumento.Size = new System.Drawing.Size(189, 17);
            this.rdbNroDocumento.TabIndex = 2;
            this.rdbNroDocumento.TabStop = true;
            this.rdbNroDocumento.Text = "Buscar por Numero de Documento";
            this.rdbNroDocumento.UseVisualStyleBackColor = true;
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(24, 62);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(116, 17);
            this.rdbNombre.TabIndex = 3;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Buscar por Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            // 
            // dtgDetalleClientes
            // 
            this.dtgDetalleClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalleClientes.Location = new System.Drawing.Point(51, 155);
            this.dtgDetalleClientes.Name = "dtgDetalleClientes";
            this.dtgDetalleClientes.Size = new System.Drawing.Size(438, 150);
            this.dtgDetalleClientes.TabIndex = 4;
            this.dtgDetalleClientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDetalleClientes_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(191, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Doble click en una celda para seleccionar un cliente";
            // 
            // frmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgDetalleClientes);
            this.Controls.Add(this.rdbNombre);
            this.Controls.Add(this.rdbNroDocumento);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnBuscar);
            this.Name = "frmConsultaCliente";
            this.Text = "Busqueda de Clientes";
            this.Load += new System.EventHandler(this.frmConsultaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.RadioButton rdbNroDocumento;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.DataGridView dtgDetalleClientes;
        private System.Windows.Forms.Label label1;
    }
}
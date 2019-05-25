namespace Interfaz_Proyecto_Bibliografia
{
    partial class frmVentaBibliografias
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
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCondicionVenta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.rdbContado = new System.Windows.Forms.RadioButton();
            this.rdbCredito = new System.Windows.Forms.RadioButton();
            this.dtgDetalleVenta = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.lblBibliografia = new System.Windows.Forms.Label();
            this.cmbLibro = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Location = new System.Drawing.Point(51, 48);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(82, 13);
            this.lblFechaEmision.TabIndex = 0;
            this.lblFechaEmision.Text = "Fecha Emision: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(310, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(122, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre o Razon Social:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(51, 122);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblCondicionVenta
            // 
            this.lblCondicionVenta.AutoSize = true;
            this.lblCondicionVenta.Location = new System.Drawing.Point(310, 48);
            this.lblCondicionVenta.Name = "lblCondicionVenta";
            this.lblCondicionVenta.Size = new System.Drawing.Size(103, 13);
            this.lblCondicionVenta.TabIndex = 3;
            this.lblCondicionVenta.Text = "Condicion de Venta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ruc o CI: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(438, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(167, 115);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 2;
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(167, 74);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(100, 20);
            this.txtCI.TabIndex = 1;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(438, 115);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 3;
            // 
            // rdbContado
            // 
            this.rdbContado.AutoSize = true;
            this.rdbContado.Location = new System.Drawing.Point(438, 44);
            this.rdbContado.Name = "rdbContado";
            this.rdbContado.Size = new System.Drawing.Size(65, 17);
            this.rdbContado.TabIndex = 11;
            this.rdbContado.TabStop = true;
            this.rdbContado.Text = "Contado";
            this.rdbContado.UseVisualStyleBackColor = true;
            // 
            // rdbCredito
            // 
            this.rdbCredito.AutoSize = true;
            this.rdbCredito.Location = new System.Drawing.Point(525, 44);
            this.rdbCredito.Name = "rdbCredito";
            this.rdbCredito.Size = new System.Drawing.Size(58, 17);
            this.rdbCredito.TabIndex = 12;
            this.rdbCredito.TabStop = true;
            this.rdbCredito.Text = "Credito";
            this.rdbCredito.UseVisualStyleBackColor = true;
            // 
            // dtgDetalleVenta
            // 
            this.dtgDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalleVenta.Location = new System.Drawing.Point(54, 230);
            this.dtgDetalleVenta.Name = "dtgDetalleVenta";
            this.dtgDetalleVenta.Size = new System.Drawing.Size(500, 150);
            this.dtgDetalleVenta.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(54, 433);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(167, 433);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(277, 433);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(396, 433);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEmision.Location = new System.Drawing.Point(167, 40);
            this.dtpFechaEmision.MaxDate = new System.DateTime(3598, 1, 1, 0, 0, 0, 0);
            this.dtpFechaEmision.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaEmision.TabIndex = 18;
            // 
            // lblBibliografia
            // 
            this.lblBibliografia.AutoSize = true;
            this.lblBibliografia.Location = new System.Drawing.Point(51, 158);
            this.lblBibliografia.Name = "lblBibliografia";
            this.lblBibliografia.Size = new System.Drawing.Size(61, 13);
            this.lblBibliografia.TabIndex = 19;
            this.lblBibliografia.Text = "Bibliografia:";
            // 
            // cmbLibro
            // 
            this.cmbLibro.FormattingEnabled = true;
            this.cmbLibro.Location = new System.Drawing.Point(167, 149);
            this.cmbLibro.Name = "cmbLibro";
            this.cmbLibro.Size = new System.Drawing.Size(100, 21);
            this.cmbLibro.TabIndex = 4;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(51, 191);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 13);
            this.lblCantidad.TabIndex = 21;
            this.lblCantidad.Text = "Cantidad: ";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(167, 184);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 5;
            // 
            // frmVentaBibliografias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cmbLibro);
            this.Controls.Add(this.lblBibliografia);
            this.Controls.Add(this.dtpFechaEmision);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgDetalleVenta);
            this.Controls.Add(this.rdbCredito);
            this.Controls.Add(this.rdbContado);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCondicionVenta);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblFechaEmision);
            this.Name = "frmVentaBibliografias";
            this.Text = "Venta de Bibliografias";
            this.Load += new System.EventHandler(this.frmVentaBibliografias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCondicionVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.RadioButton rdbContado;
        private System.Windows.Forms.RadioButton rdbCredito;
        private System.Windows.Forms.DataGridView dtgDetalleVenta;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.Label lblBibliografia;
        private System.Windows.Forms.ComboBox cmbLibro;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
    }
}
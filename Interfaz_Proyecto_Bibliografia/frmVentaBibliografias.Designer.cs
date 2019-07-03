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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentaBibliografias));
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.lblBibliografia = new System.Windows.Forms.Label();
            this.cmbLibro = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNroTimbrado = new System.Windows.Forms.TextBox();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtgVentaDetalle = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentaDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Location = new System.Drawing.Point(402, 92);
            this.lblFechaEmision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(108, 17);
            this.lblFechaEmision.TabIndex = 0;
            this.lblFechaEmision.Text = "Fecha Emision: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(49, 140);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(161, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre o Razon Social:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(142, 188);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(71, 17);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblCondicionVenta
            // 
            this.lblCondicionVenta.AutoSize = true;
            this.lblCondicionVenta.Location = new System.Drawing.Point(402, 136);
            this.lblCondicionVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCondicionVenta.Name = "lblCondicionVenta";
            this.lblCondicionVenta.Size = new System.Drawing.Size(135, 17);
            this.lblCondicionVenta.TabIndex = 3;
            this.lblCondicionVenta.Text = "Condicion de Venta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ruc o CI: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(220, 137);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(223, 180);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(132, 22);
            this.txtDireccion.TabIndex = 2;
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(223, 92);
            this.txtCI.Margin = new System.Windows.Forms.Padding(4);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(132, 22);
            this.txtCI.TabIndex = 1;
            this.txtCI.Leave += new System.EventHandler(this.txtCI_Leave);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(223, 226);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(132, 22);
            this.txtTelefono.TabIndex = 3;
            // 
            // rdbContado
            // 
            this.rdbContado.AutoSize = true;
            this.rdbContado.Location = new System.Drawing.Point(548, 136);
            this.rdbContado.Margin = new System.Windows.Forms.Padding(4);
            this.rdbContado.Name = "rdbContado";
            this.rdbContado.Size = new System.Drawing.Size(82, 21);
            this.rdbContado.TabIndex = 11;
            this.rdbContado.TabStop = true;
            this.rdbContado.Text = "Contado";
            this.rdbContado.UseVisualStyleBackColor = true;
            // 
            // rdbCredito
            // 
            this.rdbCredito.AutoSize = true;
            this.rdbCredito.CausesValidation = false;
            this.rdbCredito.Location = new System.Drawing.Point(649, 136);
            this.rdbCredito.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCredito.Name = "rdbCredito";
            this.rdbCredito.Size = new System.Drawing.Size(74, 21);
            this.rdbCredito.TabIndex = 12;
            this.rdbCredito.TabStop = true;
            this.rdbCredito.Text = "Credito";
            this.rdbCredito.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(224, 317);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(346, 317);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEmision.Location = new System.Drawing.Point(518, 92);
            this.dtpFechaEmision.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaEmision.MaxDate = new System.DateTime(3598, 1, 1, 0, 0, 0, 0);
            this.dtpFechaEmision.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(132, 22);
            this.dtpFechaEmision.TabIndex = 18;
            // 
            // lblBibliografia
            // 
            this.lblBibliografia.AutoSize = true;
            this.lblBibliografia.Location = new System.Drawing.Point(401, 180);
            this.lblBibliografia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBibliografia.Name = "lblBibliografia";
            this.lblBibliografia.Size = new System.Drawing.Size(82, 17);
            this.lblBibliografia.TabIndex = 19;
            this.lblBibliografia.Text = "Bibliografia:";
            // 
            // cmbLibro
            // 
            this.cmbLibro.FormattingEnabled = true;
            this.cmbLibro.Location = new System.Drawing.Point(498, 181);
            this.cmbLibro.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLibro.Name = "cmbLibro";
            this.cmbLibro.Size = new System.Drawing.Size(152, 24);
            this.cmbLibro.TabIndex = 4;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(402, 223);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(72, 17);
            this.lblCantidad.TabIndex = 21;
            this.lblCantidad.Text = "Cantidad: ";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(498, 218);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(72, 22);
            this.txtCantidad.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Timbrado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nro Factura:";
            // 
            // txtNroTimbrado
            // 
            this.txtNroTimbrado.Location = new System.Drawing.Point(487, 42);
            this.txtNroTimbrado.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroTimbrado.Name = "txtNroTimbrado";
            this.txtNroTimbrado.Size = new System.Drawing.Size(132, 22);
            this.txtNroTimbrado.TabIndex = 24;
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(223, 42);
            this.txtNroFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(132, 22);
            this.txtNroFactura.TabIndex = 25;
            this.txtNroFactura.Leave += new System.EventHandler(this.txtNroFactura_Leave);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(470, 317);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtgVentaDetalle
            // 
            this.dtgVentaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentaDetalle.Location = new System.Drawing.Point(126, 364);
            this.dtgVentaDetalle.Name = "dtgVentaDetalle";
            this.dtgVentaDetalle.RowTemplate.Height = 24;
            this.dtgVentaDetalle.Size = new System.Drawing.Size(664, 210);
            this.dtgVentaDetalle.TabIndex = 27;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(690, 616);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "SubTotal";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(658, 218);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(132, 22);
            this.txtPrecio.TabIndex = 31;
            this.txtPrecio.Leave += new System.EventHandler(this.txtPrecio_Leave);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(658, 264);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(132, 22);
            this.txtSubTotal.TabIndex = 32;
            // 
            // frmVentaBibliografias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 713);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtgVentaDetalle);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtNroFactura);
            this.Controls.Add(this.txtNroTimbrado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cmbLibro);
            this.Controls.Add(this.lblBibliografia);
            this.Controls.Add(this.dtpFechaEmision);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVentaBibliografias";
            this.Text = "Venta de Bibliografias";
            this.Load += new System.EventHandler(this.frmVentaBibliografias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentaDetalle)).EndInit();
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
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.Label lblBibliografia;
        private System.Windows.Forms.ComboBox cmbLibro;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNroTimbrado;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dtgVentaDetalle;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtSubTotal;
    }
}
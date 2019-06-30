namespace Interfaz_Proyecto_Bibliografia
{
    partial class frmInformeVenta
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
            this.dtgVentaPendiente = new System.Windows.Forms.DataGridView();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtgVentaConfirmada = new System.Windows.Forms.DataGridView();
            this.Columna1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentaPendiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentaConfirmada)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVentaPendiente
            // 
            this.dtgVentaPendiente.AllowUserToAddRows = false;
            this.dtgVentaPendiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentaPendiente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columna1,
            this.Columna2,
            this.Columna3,
            this.Column1,
            this.Column3,
            this.Columna5,
            this.Columna7});
            this.dtgVentaPendiente.Location = new System.Drawing.Point(63, 62);
            this.dtgVentaPendiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgVentaPendiente.Name = "dtgVentaPendiente";
            this.dtgVentaPendiente.RowTemplate.Height = 24;
            this.dtgVentaPendiente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVentaPendiente.Size = new System.Drawing.Size(989, 235);
            this.dtgVentaPendiente.TabIndex = 0;
            this.dtgVentaPendiente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgVentaPendiente_MouseClick);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(789, 314);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 28);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ventas Confirmadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ventas Pendientes";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(621, 314);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 28);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtgVentaConfirmada
            // 
            this.dtgVentaConfirmada.AllowUserToAddRows = false;
            this.dtgVentaConfirmada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentaConfirmada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column2,
            this.Column4,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6});
            this.dtgVentaConfirmada.Location = new System.Drawing.Point(63, 374);
            this.dtgVentaConfirmada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgVentaConfirmada.Name = "dtgVentaConfirmada";
            this.dtgVentaConfirmada.RowTemplate.Height = 24;
            this.dtgVentaConfirmada.Size = new System.Drawing.Size(992, 235);
            this.dtgVentaConfirmada.TabIndex = 6;
            // 
            // Columna1
            // 
            this.Columna1.HeaderText = "Selecciona";
            this.Columna1.Name = "Columna1";
            // 
            // Columna2
            // 
            this.Columna2.HeaderText = "Fecha Emision";
            this.Columna2.Name = "Columna2";
            // 
            // Columna3
            // 
            this.Columna3.HeaderText = "Cond. Venta";
            this.Columna3.Name = "Columna3";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Razon Social";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Bibliografia";
            this.Column3.Name = "Column3";
            // 
            // Columna5
            // 
            this.Columna5.HeaderText = "Cantidad";
            this.Columna5.Name = "Columna5";
            // 
            // Columna7
            // 
            this.Columna7.HeaderText = "SubTotal";
            this.Columna7.Name = "Columna7";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Fecha Emision";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Cond. Venta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Razon Social";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Bibliografia";
            this.Column4.Name = "Column4";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "SubTotal";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // frmInformeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 662);
            this.Controls.Add(this.dtgVentaConfirmada);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dtgVentaPendiente);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmInformeVenta";
            this.Text = "frmInformeVenta";
            this.Load += new System.EventHandler(this.frmInformeVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentaPendiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentaConfirmada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVentaPendiente;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dtgVentaConfirmada;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
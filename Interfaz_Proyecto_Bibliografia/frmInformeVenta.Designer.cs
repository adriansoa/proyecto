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
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtgVentaConfirmada = new System.Windows.Forms.DataGridView();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentaPendiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentaConfirmada)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVentaPendiente
            // 
            this.dtgVentaPendiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentaPendiente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estado});
            this.dtgVentaPendiente.Location = new System.Drawing.Point(63, 62);
            this.dtgVentaPendiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgVentaPendiente.Name = "dtgVentaPendiente";
            this.dtgVentaPendiente.RowTemplate.Height = 24;
            this.dtgVentaPendiente.Size = new System.Drawing.Size(989, 235);
            this.dtgVentaPendiente.TabIndex = 0;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // dtgVentaConfirmada
            // 
            this.dtgVentaConfirmada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentaConfirmada.Location = new System.Drawing.Point(63, 372);
            this.dtgVentaConfirmada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgVentaConfirmada.Name = "dtgVentaConfirmada";
            this.dtgVentaConfirmada.RowTemplate.Height = 24;
            this.dtgVentaConfirmada.Size = new System.Drawing.Size(989, 235);
            this.dtgVentaConfirmada.TabIndex = 1;
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
            // frmInformeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 662);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dtgVentaConfirmada);
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
        private System.Windows.Forms.DataGridView dtgVentaConfirmada;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultar;
    }
}
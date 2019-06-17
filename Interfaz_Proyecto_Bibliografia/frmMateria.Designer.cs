namespace Interfaz_Proyecto_Bibliografia
{
    partial class frmMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMateria));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCantidadCreditos = new System.Windows.Forms.Label();
            this.lblTipoMateria = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCantidadCreditos = new System.Windows.Forms.TextBox();
            this.rdbObligatoria = new System.Windows.Forms.RadioButton();
            this.rdbElectiva = new System.Windows.Forms.RadioButton();
            this.dtgMaterias = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(800, 266);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 27;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(800, 201);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(800, 128);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(800, 62);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(39, 62);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 17);
            this.lblCodigo.TabIndex = 28;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(39, 114);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCantidadCreditos
            // 
            this.lblCantidadCreditos.AutoSize = true;
            this.lblCantidadCreditos.Location = new System.Drawing.Point(39, 164);
            this.lblCantidadCreditos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadCreditos.Name = "lblCantidadCreditos";
            this.lblCantidadCreditos.Size = new System.Drawing.Size(140, 17);
            this.lblCantidadCreditos.TabIndex = 30;
            this.lblCantidadCreditos.Text = "Cantidad de Creditos";
            // 
            // lblTipoMateria
            // 
            this.lblTipoMateria.AutoSize = true;
            this.lblTipoMateria.Location = new System.Drawing.Point(39, 213);
            this.lblTipoMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoMateria.Name = "lblTipoMateria";
            this.lblTipoMateria.Size = new System.Drawing.Size(87, 17);
            this.lblTipoMateria.TabIndex = 31;
            this.lblTipoMateria.Text = "Tipo Materia";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(205, 52);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(205, 106);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCantidadCreditos
            // 
            this.txtCantidadCreditos.Location = new System.Drawing.Point(205, 155);
            this.txtCantidadCreditos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidadCreditos.Name = "txtCantidadCreditos";
            this.txtCantidadCreditos.Size = new System.Drawing.Size(132, 22);
            this.txtCantidadCreditos.TabIndex = 2;
            // 
            // rdbObligatoria
            // 
            this.rdbObligatoria.AutoSize = true;
            this.rdbObligatoria.Location = new System.Drawing.Point(193, 208);
            this.rdbObligatoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbObligatoria.Name = "rdbObligatoria";
            this.rdbObligatoria.Size = new System.Drawing.Size(98, 21);
            this.rdbObligatoria.TabIndex = 3;
            this.rdbObligatoria.TabStop = true;
            this.rdbObligatoria.Text = "Obligatoria";
            this.rdbObligatoria.UseVisualStyleBackColor = true;
            // 
            // rdbElectiva
            // 
            this.rdbElectiva.AutoSize = true;
            this.rdbElectiva.Location = new System.Drawing.Point(329, 208);
            this.rdbElectiva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbElectiva.Name = "rdbElectiva";
            this.rdbElectiva.Size = new System.Drawing.Size(78, 21);
            this.rdbElectiva.TabIndex = 36;
            this.rdbElectiva.TabStop = true;
            this.rdbElectiva.Text = "Electiva";
            this.rdbElectiva.UseVisualStyleBackColor = true;
            // 
            // dtgMaterias
            // 
            this.dtgMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMaterias.Location = new System.Drawing.Point(43, 334);
            this.dtgMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgMaterias.Name = "dtgMaterias";
            this.dtgMaterias.Size = new System.Drawing.Size(789, 185);
            this.dtgMaterias.TabIndex = 37;
            this.dtgMaterias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMaterias_CellContentClick);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(329, 277);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 28);
            this.btnConsultar.TabIndex = 38;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtgMaterias);
            this.Controls.Add(this.rdbElectiva);
            this.Controls.Add(this.rdbObligatoria);
            this.Controls.Add(this.txtCantidadCreditos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblTipoMateria);
            this.Controls.Add(this.lblCantidadCreditos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMateria";
            this.Text = "Formulario de Materias";
            this.Load += new System.EventHandler(this.frmMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCantidadCreditos;
        private System.Windows.Forms.Label lblTipoMateria;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCantidadCreditos;
        private System.Windows.Forms.RadioButton rdbObligatoria;
        private System.Windows.Forms.RadioButton rdbElectiva;
        private System.Windows.Forms.DataGridView dtgMaterias;
        private System.Windows.Forms.Button btnConsultar;
    }
}
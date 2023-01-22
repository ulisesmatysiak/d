namespace presentacion
{
    partial class frmDiscoteca
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDiscoteca = new System.Windows.Forms.DataGridView();
            this.pboDiscoteca = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.cboEdicion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscoteca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboDiscoteca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiscoteca
            // 
            this.dgvDiscoteca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDiscoteca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscoteca.Location = new System.Drawing.Point(311, 66);
            this.dgvDiscoteca.Name = "dgvDiscoteca";
            this.dgvDiscoteca.Size = new System.Drawing.Size(558, 215);
            this.dgvDiscoteca.TabIndex = 0;
            this.dgvDiscoteca.SelectionChanged += new System.EventHandler(this.dgvDiscoteca_SelectionChanged);
            // 
            // pboDiscoteca
            // 
            this.pboDiscoteca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pboDiscoteca.Location = new System.Drawing.Point(12, 66);
            this.pboDiscoteca.Name = "pboDiscoteca";
            this.pboDiscoteca.Size = new System.Drawing.Size(268, 372);
            this.pboDiscoteca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboDiscoteca.TabIndex = 1;
            this.pboDiscoteca.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregar.Location = new System.Drawing.Point(397, 345);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificar.Location = new System.Drawing.Point(595, 345);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminar.Location = new System.Drawing.Point(793, 345);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFiltrar.Location = new System.Drawing.Point(794, 20);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // lblEstilo
            // 
            this.lblEstilo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(107, 20);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(32, 13);
            this.lblEstilo.TabIndex = 6;
            this.lblEstilo.Text = "Estilo";
            // 
            // cboGenero
            // 
            this.cboGenero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(187, 20);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(121, 21);
            this.cboGenero.TabIndex = 7;
            // 
            // lblEdicion
            // 
            this.lblEdicion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Location = new System.Drawing.Point(369, 20);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(42, 13);
            this.lblEdicion.TabIndex = 8;
            this.lblEdicion.Text = "Edicion";
            // 
            // cboEdicion
            // 
            this.cboEdicion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboEdicion.FormattingEnabled = true;
            this.cboEdicion.Location = new System.Drawing.Point(449, 22);
            this.cboEdicion.Name = "cboEdicion";
            this.cboEdicion.Size = new System.Drawing.Size(121, 21);
            this.cboEdicion.TabIndex = 9;
            // 
            // frmDiscoteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.cboEdicion);
            this.Controls.Add(this.lblEdicion);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pboDiscoteca);
            this.Controls.Add(this.dgvDiscoteca);
            this.Name = "frmDiscoteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discoteca";
            this.Load += new System.EventHandler(this.frmDiscoteca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscoteca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboDiscoteca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiscoteca;
        private System.Windows.Forms.PictureBox pboDiscoteca;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Label lblEdicion;
        private System.Windows.Forms.ComboBox cboEdicion;
    }
}


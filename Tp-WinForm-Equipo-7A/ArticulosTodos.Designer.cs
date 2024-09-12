namespace Tp_WinForm_Equipo_7A
{
    partial class TodosArticulos
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
            this.lblCatalogo = new System.Windows.Forms.Label();
            this.dgv_ArticulosTodos = new System.Windows.Forms.DataGridView();
            this.pxbArticulo = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblDescripcionCatalogo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbFitroRapido = new System.Windows.Forms.TextBox();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltroCompleto = new System.Windows.Forms.Label();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.txbFiltroCompleto = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ArticulosTodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCatalogo
            // 
            this.lblCatalogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCatalogo.AutoSize = true;
            this.lblCatalogo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCatalogo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogo.Location = new System.Drawing.Point(403, 42);
            this.lblCatalogo.Name = "lblCatalogo";
            this.lblCatalogo.Size = new System.Drawing.Size(369, 39);
            this.lblCatalogo.TabIndex = 0;
            this.lblCatalogo.Text = "Administrador de Catálogo";
            this.lblCatalogo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCatalogo.UseMnemonic = false;
            // 
            // dgv_ArticulosTodos
            // 
            this.dgv_ArticulosTodos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_ArticulosTodos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_ArticulosTodos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_ArticulosTodos.Location = new System.Drawing.Point(48, 212);
            this.dgv_ArticulosTodos.MultiSelect = false;
            this.dgv_ArticulosTodos.Name = "dgv_ArticulosTodos";
            this.dgv_ArticulosTodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ArticulosTodos.Size = new System.Drawing.Size(647, 370);
            this.dgv_ArticulosTodos.TabIndex = 1;
            this.dgv_ArticulosTodos.SelectionChanged += new System.EventHandler(this.dgv_ArticulosTodos_SelectionChanged);
            // 
            // pxbArticulo
            // 
            this.pxbArticulo.Location = new System.Drawing.Point(784, 212);
            this.pxbArticulo.Name = "pxbArticulo";
            this.pxbArticulo.Size = new System.Drawing.Size(349, 370);
            this.pxbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxbArticulo.TabIndex = 2;
            this.pxbArticulo.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(48, 600);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 36);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(206, 600);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 36);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(363, 600);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 36);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblDescripcionCatalogo
            // 
            this.lblDescripcionCatalogo.AutoSize = true;
            this.lblDescripcionCatalogo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCatalogo.Location = new System.Drawing.Point(45, 112);
            this.lblDescripcionCatalogo.Name = "lblDescripcionCatalogo";
            this.lblDescripcionCatalogo.Size = new System.Drawing.Size(1088, 17);
            this.lblDescripcionCatalogo.TabIndex = 6;
            this.lblDescripcionCatalogo.Text = "Administra y organiza los artículos de tu catálogo de manera eficiente. Agrega, m" +
    "odifica o elimina productos, y mantén actualizada la información clave de tu inv" +
    "entario en un solo lugar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(48, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filtro rapido";
            // 
            // txbFitroRapido
            // 
            this.txbFitroRapido.Location = new System.Drawing.Point(139, 165);
            this.txbFitroRapido.Name = "txbFitroRapido";
            this.txbFitroRapido.Size = new System.Drawing.Size(546, 20);
            this.txbFitroRapido.TabIndex = 8;
            this.txbFitroRapido.TextChanged += new System.EventHandler(this.txbFitroRapido_TextChanged);
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnVerDetalle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalle.Location = new System.Drawing.Point(918, 600);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(119, 36);
            this.btnVerDetalle.TabIndex = 9;
            this.btnVerDetalle.Text = "Ver detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = false;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCampo.Location = new System.Drawing.Point(48, 660);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(51, 17);
            this.lblCampo.TabIndex = 10;
            this.lblCampo.Text = "Campo";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCriterio.Location = new System.Drawing.Point(240, 660);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(54, 17);
            this.lblCriterio.TabIndex = 11;
            this.lblCriterio.Text = "Criterio";
            // 
            // lblFiltroCompleto
            // 
            this.lblFiltroCompleto.AutoSize = true;
            this.lblFiltroCompleto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFiltroCompleto.Location = new System.Drawing.Point(441, 664);
            this.lblFiltroCompleto.Name = "lblFiltroCompleto";
            this.lblFiltroCompleto.Size = new System.Drawing.Size(41, 17);
            this.lblFiltroCompleto.TabIndex = 12;
            this.lblFiltroCompleto.Text = "Filtro";
            // 
            // cboCriterio
            // 
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(300, 660);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio.TabIndex = 13;
            // 
            // cboCampo
            // 
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(105, 660);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 14;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cmbCampo_SelectedIndexChanged);
            // 
            // txbFiltroCompleto
            // 
            this.txbFiltroCompleto.Location = new System.Drawing.Point(488, 661);
            this.txbFiltroCompleto.Name = "txbFiltroCompleto";
            this.txbFiltroCompleto.Size = new System.Drawing.Size(121, 20);
            this.txbFiltroCompleto.TabIndex = 15;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(637, 650);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 36);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TodosArticulos
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1185, 725);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbFiltroCompleto);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.lblFiltroCompleto);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.txbFitroRapido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescripcionCatalogo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pxbArticulo);
            this.Controls.Add(this.dgv_ArticulosTodos);
            this.Controls.Add(this.lblCatalogo);
            this.Name = "TodosArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TodosArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ArticulosTodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCatalogo;
        private System.Windows.Forms.DataGridView dgv_ArticulosTodos;
        private System.Windows.Forms.PictureBox pxbArticulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblDescripcionCatalogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFitroRapido;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltroCompleto;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.TextBox txbFiltroCompleto;
        private System.Windows.Forms.Button btnBuscar;
    }
}


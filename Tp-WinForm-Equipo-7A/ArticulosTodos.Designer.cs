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
            this.btnAgregar.Location = new System.Drawing.Point(128, 611);
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
            this.btnModificar.Location = new System.Drawing.Point(293, 611);
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
            this.btnEliminar.Location = new System.Drawing.Point(463, 611);
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
            // TodosArticulos
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1185, 725);
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
    }
}


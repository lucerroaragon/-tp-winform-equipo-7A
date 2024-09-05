namespace Tp_WinForm_Equipo_7A.Forms
{
    partial class EliminarArticulo
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
            this.btn_buscar_Eliminar = new System.Windows.Forms.Button();
            this.txt_busqueda_Eliminar = new System.Windows.Forms.TextBox();
            this.grpBox_filtro_Eliminar = new System.Windows.Forms.GroupBox();
            this.rb_codProducto_Eliminar = new System.Windows.Forms.RadioButton();
            this.rb_categoria_Eliminar = new System.Windows.Forms.RadioButton();
            this.rb_marca_Eliminar = new System.Windows.Forms.RadioButton();
            this.rb_nombreProducto_Eliminar = new System.Windows.Forms.RadioButton();
            this.lbl_BuscarArticulo_Eliminar = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_ModificarPorducto = new System.Windows.Forms.Label();
            this.grpBox_filtro_Eliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_buscar_Eliminar
            // 
            this.btn_buscar_Eliminar.Location = new System.Drawing.Point(606, 171);
            this.btn_buscar_Eliminar.Name = "btn_buscar_Eliminar";
            this.btn_buscar_Eliminar.Size = new System.Drawing.Size(84, 30);
            this.btn_buscar_Eliminar.TabIndex = 18;
            this.btn_buscar_Eliminar.Text = "Buscar";
            this.btn_buscar_Eliminar.UseVisualStyleBackColor = true;
            // 
            // txt_busqueda_Eliminar
            // 
            this.txt_busqueda_Eliminar.Location = new System.Drawing.Point(177, 181);
            this.txt_busqueda_Eliminar.Name = "txt_busqueda_Eliminar";
            this.txt_busqueda_Eliminar.Size = new System.Drawing.Size(381, 20);
            this.txt_busqueda_Eliminar.TabIndex = 17;
            // 
            // grpBox_filtro_Eliminar
            // 
            this.grpBox_filtro_Eliminar.Controls.Add(this.rb_codProducto_Eliminar);
            this.grpBox_filtro_Eliminar.Controls.Add(this.rb_categoria_Eliminar);
            this.grpBox_filtro_Eliminar.Controls.Add(this.rb_marca_Eliminar);
            this.grpBox_filtro_Eliminar.Controls.Add(this.rb_nombreProducto_Eliminar);
            this.grpBox_filtro_Eliminar.Location = new System.Drawing.Point(96, 117);
            this.grpBox_filtro_Eliminar.Name = "grpBox_filtro_Eliminar";
            this.grpBox_filtro_Eliminar.Size = new System.Drawing.Size(345, 46);
            this.grpBox_filtro_Eliminar.TabIndex = 16;
            this.grpBox_filtro_Eliminar.TabStop = false;
            this.grpBox_filtro_Eliminar.Text = "Filtro";
            // 
            // rb_codProducto_Eliminar
            // 
            this.rb_codProducto_Eliminar.AutoSize = true;
            this.rb_codProducto_Eliminar.Location = new System.Drawing.Point(6, 19);
            this.rb_codProducto_Eliminar.Name = "rb_codProducto_Eliminar";
            this.rb_codProducto_Eliminar.Size = new System.Drawing.Size(90, 17);
            this.rb_codProducto_Eliminar.TabIndex = 3;
            this.rb_codProducto_Eliminar.TabStop = true;
            this.rb_codProducto_Eliminar.Text = "Cod Producto";
            this.rb_codProducto_Eliminar.UseVisualStyleBackColor = true;
            // 
            // rb_categoria_Eliminar
            // 
            this.rb_categoria_Eliminar.AutoSize = true;
            this.rb_categoria_Eliminar.Location = new System.Drawing.Point(277, 19);
            this.rb_categoria_Eliminar.Name = "rb_categoria_Eliminar";
            this.rb_categoria_Eliminar.Size = new System.Drawing.Size(70, 17);
            this.rb_categoria_Eliminar.TabIndex = 2;
            this.rb_categoria_Eliminar.TabStop = true;
            this.rb_categoria_Eliminar.Text = "Categoria";
            this.rb_categoria_Eliminar.UseVisualStyleBackColor = true;
            // 
            // rb_marca_Eliminar
            // 
            this.rb_marca_Eliminar.AutoSize = true;
            this.rb_marca_Eliminar.Location = new System.Drawing.Point(216, 19);
            this.rb_marca_Eliminar.Name = "rb_marca_Eliminar";
            this.rb_marca_Eliminar.Size = new System.Drawing.Size(55, 17);
            this.rb_marca_Eliminar.TabIndex = 1;
            this.rb_marca_Eliminar.TabStop = true;
            this.rb_marca_Eliminar.Text = "Marca";
            this.rb_marca_Eliminar.UseVisualStyleBackColor = true;
            // 
            // rb_nombreProducto_Eliminar
            // 
            this.rb_nombreProducto_Eliminar.AutoSize = true;
            this.rb_nombreProducto_Eliminar.Location = new System.Drawing.Point(102, 19);
            this.rb_nombreProducto_Eliminar.Name = "rb_nombreProducto_Eliminar";
            this.rb_nombreProducto_Eliminar.Size = new System.Drawing.Size(108, 17);
            this.rb_nombreProducto_Eliminar.TabIndex = 0;
            this.rb_nombreProducto_Eliminar.TabStop = true;
            this.rb_nombreProducto_Eliminar.Text = "Nombre Producto";
            this.rb_nombreProducto_Eliminar.UseVisualStyleBackColor = true;
            // 
            // lbl_BuscarArticulo_Eliminar
            // 
            this.lbl_BuscarArticulo_Eliminar.AutoSize = true;
            this.lbl_BuscarArticulo_Eliminar.Location = new System.Drawing.Point(93, 188);
            this.lbl_BuscarArticulo_Eliminar.Name = "lbl_BuscarArticulo_Eliminar";
            this.lbl_BuscarArticulo_Eliminar.Size = new System.Drawing.Size(78, 13);
            this.lbl_BuscarArticulo_Eliminar.TabIndex = 15;
            this.lbl_BuscarArticulo_Eliminar.Text = "Buscar Articulo";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(96, 238);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(612, 389);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CodProducto";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre Producto";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Marca";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Categoria";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Detalle";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 120;
            // 
            // lbl_ModificarPorducto
            // 
            this.lbl_ModificarPorducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ModificarPorducto.AutoSize = true;
            this.lbl_ModificarPorducto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ModificarPorducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ModificarPorducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_ModificarPorducto.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_ModificarPorducto.Location = new System.Drawing.Point(236, 21);
            this.lbl_ModificarPorducto.Name = "lbl_ModificarPorducto";
            this.lbl_ModificarPorducto.Size = new System.Drawing.Size(313, 53);
            this.lbl_ModificarPorducto.TabIndex = 13;
            this.lbl_ModificarPorducto.Text = "Eliminar Articulo";
            this.lbl_ModificarPorducto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_ModificarPorducto.UseMnemonic = false;
            // 
            // EliminarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.btn_buscar_Eliminar);
            this.Controls.Add(this.txt_busqueda_Eliminar);
            this.Controls.Add(this.grpBox_filtro_Eliminar);
            this.Controls.Add(this.lbl_BuscarArticulo_Eliminar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbl_ModificarPorducto);
            this.Name = "EliminarArticulo";
            this.Text = "EliminarArticulo";
            this.grpBox_filtro_Eliminar.ResumeLayout(false);
            this.grpBox_filtro_Eliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscar_Eliminar;
        private System.Windows.Forms.TextBox txt_busqueda_Eliminar;
        private System.Windows.Forms.GroupBox grpBox_filtro_Eliminar;
        private System.Windows.Forms.RadioButton rb_codProducto_Eliminar;
        private System.Windows.Forms.RadioButton rb_categoria_Eliminar;
        private System.Windows.Forms.RadioButton rb_marca_Eliminar;
        private System.Windows.Forms.RadioButton rb_nombreProducto_Eliminar;
        private System.Windows.Forms.Label lbl_BuscarArticulo_Eliminar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lbl_ModificarPorducto;
    }
}
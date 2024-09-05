namespace Tp_WinForm_Equipo_7A.Forms
{
    partial class ListaArticulos
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_BuscarArticulo = new System.Windows.Forms.Label();
            this.grpBox_filtro = new System.Windows.Forms.GroupBox();
            this.rb_nombreProducto = new System.Windows.Forms.RadioButton();
            this.rb_marca = new System.Windows.Forms.RadioButton();
            this.rb_categoria = new System.Windows.Forms.RadioButton();
            this.rb_codProducto = new System.Windows.Forms.RadioButton();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.grpBox_filtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Productos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseMnemonic = false;
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
            this.listView1.Location = new System.Drawing.Point(85, 226);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(612, 389);
            this.listView1.TabIndex = 2;
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
            // lbl_BuscarArticulo
            // 
            this.lbl_BuscarArticulo.AutoSize = true;
            this.lbl_BuscarArticulo.Location = new System.Drawing.Point(82, 176);
            this.lbl_BuscarArticulo.Name = "lbl_BuscarArticulo";
            this.lbl_BuscarArticulo.Size = new System.Drawing.Size(78, 13);
            this.lbl_BuscarArticulo.TabIndex = 3;
            this.lbl_BuscarArticulo.Text = "Buscar Articulo";
            // 
            // grpBox_filtro
            // 
            this.grpBox_filtro.Controls.Add(this.rb_codProducto);
            this.grpBox_filtro.Controls.Add(this.rb_categoria);
            this.grpBox_filtro.Controls.Add(this.rb_marca);
            this.grpBox_filtro.Controls.Add(this.rb_nombreProducto);
            this.grpBox_filtro.Location = new System.Drawing.Point(85, 105);
            this.grpBox_filtro.Name = "grpBox_filtro";
            this.grpBox_filtro.Size = new System.Drawing.Size(345, 46);
            this.grpBox_filtro.TabIndex = 4;
            this.grpBox_filtro.TabStop = false;
            this.grpBox_filtro.Text = "Filtro";
            // 
            // rb_nombreProducto
            // 
            this.rb_nombreProducto.AutoSize = true;
            this.rb_nombreProducto.Location = new System.Drawing.Point(102, 19);
            this.rb_nombreProducto.Name = "rb_nombreProducto";
            this.rb_nombreProducto.Size = new System.Drawing.Size(108, 17);
            this.rb_nombreProducto.TabIndex = 0;
            this.rb_nombreProducto.TabStop = true;
            this.rb_nombreProducto.Text = "Nombre Producto";
            this.rb_nombreProducto.UseVisualStyleBackColor = true;
            // 
            // rb_marca
            // 
            this.rb_marca.AutoSize = true;
            this.rb_marca.Location = new System.Drawing.Point(216, 19);
            this.rb_marca.Name = "rb_marca";
            this.rb_marca.Size = new System.Drawing.Size(55, 17);
            this.rb_marca.TabIndex = 1;
            this.rb_marca.TabStop = true;
            this.rb_marca.Text = "Marca";
            this.rb_marca.UseVisualStyleBackColor = true;
            // 
            // rb_categoria
            // 
            this.rb_categoria.AutoSize = true;
            this.rb_categoria.Location = new System.Drawing.Point(277, 19);
            this.rb_categoria.Name = "rb_categoria";
            this.rb_categoria.Size = new System.Drawing.Size(70, 17);
            this.rb_categoria.TabIndex = 2;
            this.rb_categoria.TabStop = true;
            this.rb_categoria.Text = "Categoria";
            this.rb_categoria.UseVisualStyleBackColor = true;
            // 
            // rb_codProducto
            // 
            this.rb_codProducto.AutoSize = true;
            this.rb_codProducto.Location = new System.Drawing.Point(6, 19);
            this.rb_codProducto.Name = "rb_codProducto";
            this.rb_codProducto.Size = new System.Drawing.Size(90, 17);
            this.rb_codProducto.TabIndex = 3;
            this.rb_codProducto.TabStop = true;
            this.rb_codProducto.Text = "Cod Producto";
            this.rb_codProducto.UseVisualStyleBackColor = true;
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(166, 169);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(381, 20);
            this.txt_busqueda.TabIndex = 5;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(595, 159);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(84, 30);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // ListaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 627);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.grpBox_filtro);
            this.Controls.Add(this.lbl_BuscarArticulo);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "ListaArticulos";
            this.Text = "ListaArticulos";
          
            this.grpBox_filtro.ResumeLayout(false);
            this.grpBox_filtro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lbl_BuscarArticulo;
        private System.Windows.Forms.GroupBox grpBox_filtro;
        private System.Windows.Forms.RadioButton rb_categoria;
        private System.Windows.Forms.RadioButton rb_marca;
        private System.Windows.Forms.RadioButton rb_nombreProducto;
        private System.Windows.Forms.RadioButton rb_codProducto;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Button btn_buscar;
    }
}
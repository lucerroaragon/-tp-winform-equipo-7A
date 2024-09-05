namespace Tp_WinForm_Equipo_7A.Forms
{
    partial class ModificarArticulo
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
            this.btn_buscar_Modificar = new System.Windows.Forms.Button();
            this.txt_busqueda_Modificar = new System.Windows.Forms.TextBox();
            this.grpBox_filtro_Modificar = new System.Windows.Forms.GroupBox();
            this.rb_codProducto_Modificar = new System.Windows.Forms.RadioButton();
            this.rb_categoria_Modificar = new System.Windows.Forms.RadioButton();
            this.rb_marca_Modificar = new System.Windows.Forms.RadioButton();
            this.rb_nombreProducto_Modificar = new System.Windows.Forms.RadioButton();
            this.lbl_BuscarArticulo_Modificar = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_ModificarPorducto = new System.Windows.Forms.Label();
            this.grpBox_filtro_Modificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_buscar_Modificar
            // 
            this.btn_buscar_Modificar.Location = new System.Drawing.Point(606, 178);
            this.btn_buscar_Modificar.Name = "btn_buscar_Modificar";
            this.btn_buscar_Modificar.Size = new System.Drawing.Size(84, 30);
            this.btn_buscar_Modificar.TabIndex = 12;
            this.btn_buscar_Modificar.Text = "Buscar";
            this.btn_buscar_Modificar.UseVisualStyleBackColor = true;
            // 
            // txt_busqueda_Modificar
            // 
            this.txt_busqueda_Modificar.Location = new System.Drawing.Point(177, 188);
            this.txt_busqueda_Modificar.Name = "txt_busqueda_Modificar";
            this.txt_busqueda_Modificar.Size = new System.Drawing.Size(381, 20);
            this.txt_busqueda_Modificar.TabIndex = 11;
            // 
            // grpBox_filtro_Modificar
            // 
            this.grpBox_filtro_Modificar.Controls.Add(this.rb_codProducto_Modificar);
            this.grpBox_filtro_Modificar.Controls.Add(this.rb_categoria_Modificar);
            this.grpBox_filtro_Modificar.Controls.Add(this.rb_marca_Modificar);
            this.grpBox_filtro_Modificar.Controls.Add(this.rb_nombreProducto_Modificar);
            this.grpBox_filtro_Modificar.Location = new System.Drawing.Point(96, 124);
            this.grpBox_filtro_Modificar.Name = "grpBox_filtro_Modificar";
            this.grpBox_filtro_Modificar.Size = new System.Drawing.Size(345, 46);
            this.grpBox_filtro_Modificar.TabIndex = 10;
            this.grpBox_filtro_Modificar.TabStop = false;
            this.grpBox_filtro_Modificar.Text = "Filtro";
            // 
            // rb_codProducto_Modificar
            // 
            this.rb_codProducto_Modificar.AutoSize = true;
            this.rb_codProducto_Modificar.Location = new System.Drawing.Point(6, 19);
            this.rb_codProducto_Modificar.Name = "rb_codProducto_Modificar";
            this.rb_codProducto_Modificar.Size = new System.Drawing.Size(90, 17);
            this.rb_codProducto_Modificar.TabIndex = 3;
            this.rb_codProducto_Modificar.TabStop = true;
            this.rb_codProducto_Modificar.Text = "Cod Producto";
            this.rb_codProducto_Modificar.UseVisualStyleBackColor = true;
            // 
            // rb_categoria_Modificar
            // 
            this.rb_categoria_Modificar.AutoSize = true;
            this.rb_categoria_Modificar.Location = new System.Drawing.Point(277, 19);
            this.rb_categoria_Modificar.Name = "rb_categoria_Modificar";
            this.rb_categoria_Modificar.Size = new System.Drawing.Size(70, 17);
            this.rb_categoria_Modificar.TabIndex = 2;
            this.rb_categoria_Modificar.TabStop = true;
            this.rb_categoria_Modificar.Text = "Categoria";
            this.rb_categoria_Modificar.UseVisualStyleBackColor = true;
            // 
            // rb_marca_Modificar
            // 
            this.rb_marca_Modificar.AutoSize = true;
            this.rb_marca_Modificar.Location = new System.Drawing.Point(216, 19);
            this.rb_marca_Modificar.Name = "rb_marca_Modificar";
            this.rb_marca_Modificar.Size = new System.Drawing.Size(55, 17);
            this.rb_marca_Modificar.TabIndex = 1;
            this.rb_marca_Modificar.TabStop = true;
            this.rb_marca_Modificar.Text = "Marca";
            this.rb_marca_Modificar.UseVisualStyleBackColor = true;
            // 
            // rb_nombreProducto_Modificar
            // 
            this.rb_nombreProducto_Modificar.AutoSize = true;
            this.rb_nombreProducto_Modificar.Location = new System.Drawing.Point(102, 19);
            this.rb_nombreProducto_Modificar.Name = "rb_nombreProducto_Modificar";
            this.rb_nombreProducto_Modificar.Size = new System.Drawing.Size(108, 17);
            this.rb_nombreProducto_Modificar.TabIndex = 0;
            this.rb_nombreProducto_Modificar.TabStop = true;
            this.rb_nombreProducto_Modificar.Text = "Nombre Producto";
            this.rb_nombreProducto_Modificar.UseVisualStyleBackColor = true;
            // 
            // lbl_BuscarArticulo_Modificar
            // 
            this.lbl_BuscarArticulo_Modificar.AutoSize = true;
            this.lbl_BuscarArticulo_Modificar.Location = new System.Drawing.Point(93, 195);
            this.lbl_BuscarArticulo_Modificar.Name = "lbl_BuscarArticulo_Modificar";
            this.lbl_BuscarArticulo_Modificar.Size = new System.Drawing.Size(78, 13);
            this.lbl_BuscarArticulo_Modificar.TabIndex = 9;
            this.lbl_BuscarArticulo_Modificar.Text = "Buscar Articulo";
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
            this.listView1.Location = new System.Drawing.Point(96, 245);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(612, 389);
            this.listView1.TabIndex = 8;
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
            this.lbl_ModificarPorducto.Location = new System.Drawing.Point(236, 28);
            this.lbl_ModificarPorducto.Name = "lbl_ModificarPorducto";
            this.lbl_ModificarPorducto.Size = new System.Drawing.Size(356, 53);
            this.lbl_ModificarPorducto.TabIndex = 7;
            this.lbl_ModificarPorducto.Text = "Modificar Producto";
            this.lbl_ModificarPorducto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_ModificarPorducto.UseMnemonic = false;
            // 
            // ModificarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 663);
            this.Controls.Add(this.btn_buscar_Modificar);
            this.Controls.Add(this.txt_busqueda_Modificar);
            this.Controls.Add(this.grpBox_filtro_Modificar);
            this.Controls.Add(this.lbl_BuscarArticulo_Modificar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbl_ModificarPorducto);
            this.Name = "ModificarArticulo";
            this.Text = "ModificarArticulo";
            this.grpBox_filtro_Modificar.ResumeLayout(false);
            this.grpBox_filtro_Modificar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscar_Modificar;
        private System.Windows.Forms.TextBox txt_busqueda_Modificar;
        private System.Windows.Forms.GroupBox grpBox_filtro_Modificar;
        private System.Windows.Forms.RadioButton rb_codProducto_Modificar;
        private System.Windows.Forms.RadioButton rb_categoria_Modificar;
        private System.Windows.Forms.RadioButton rb_marca_Modificar;
        private System.Windows.Forms.RadioButton rb_nombreProducto_Modificar;
        private System.Windows.Forms.Label lbl_BuscarArticulo_Modificar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lbl_ModificarPorducto;
    }
}
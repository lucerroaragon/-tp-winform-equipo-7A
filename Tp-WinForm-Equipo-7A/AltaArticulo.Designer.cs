namespace Tp_WinForm_Equipo_7A
{
    partial class AltaArticulo
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
            this.codigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.Label();
            this.btoAceptar = new System.Windows.Forms.Button();
            this.btoCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.pbxAltaArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAltaArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(117, 67);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(52, 17);
            this.codigo.TabIndex = 0;
            this.codigo.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(203, 67);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(167, 23);
            this.txtCodigo.TabIndex = 0;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.nombre.Location = new System.Drawing.Point(117, 101);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(58, 17);
            this.nombre.TabIndex = 2;
            this.nombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.Location = new System.Drawing.Point(203, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrecio.Location = new System.Drawing.Point(203, 172);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(167, 23);
            this.txtPrecio.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescripcion.Location = new System.Drawing.Point(203, 137);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(167, 23);
            this.txtDescripcion.TabIndex = 2;
            // 
            // descripcion
            // 
            this.descripcion.AutoSize = true;
            this.descripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.descripcion.Location = new System.Drawing.Point(117, 137);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(80, 17);
            this.descripcion.TabIndex = 7;
            this.descripcion.Text = "Descripcion";
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.precio.Location = new System.Drawing.Point(117, 172);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(46, 17);
            this.precio.TabIndex = 8;
            this.precio.Text = "Precio";
            // 
            // btoAceptar
            // 
            this.btoAceptar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btoAceptar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoAceptar.Location = new System.Drawing.Point(120, 339);
            this.btoAceptar.Name = "btoAceptar";
            this.btoAceptar.Size = new System.Drawing.Size(119, 37);
            this.btoAceptar.TabIndex = 7;
            this.btoAceptar.Text = "Aceptar";
            this.btoAceptar.UseVisualStyleBackColor = false;
            this.btoAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btoCancelar
            // 
            this.btoCancelar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btoCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoCancelar.Location = new System.Drawing.Point(255, 339);
            this.btoCancelar.Name = "btoCancelar";
            this.btoCancelar.Size = new System.Drawing.Size(119, 37);
            this.btoCancelar.TabIndex = 8;
            this.btoCancelar.Text = "Cancelar";
            this.btoCancelar.UseVisualStyleBackColor = false;
            this.btoCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(117, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(117, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Categoria";
            // 
            // cboMarca
            // 
            this.cboMarca.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(203, 244);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(167, 23);
            this.cboMarca.TabIndex = 5;
            // 
            // cboCategoria
            // 
            this.cboCategoria.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(203, 280);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(167, 23);
            this.cboCategoria.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(117, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Imagen Url";
            // 
            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUrl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUrl.Location = new System.Drawing.Point(203, 209);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(167, 23);
            this.txtUrl.TabIndex = 4;
            this.txtUrl.Leave += new System.EventHandler(this.txtUrl_Leave);
            // 
            // pbxAltaArticulo
            // 
            this.pbxAltaArticulo.Location = new System.Drawing.Point(424, 67);
            this.pbxAltaArticulo.Name = "pbxAltaArticulo";
            this.pbxAltaArticulo.Size = new System.Drawing.Size(243, 234);
            this.pbxAltaArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAltaArticulo.TabIndex = 17;
            this.pbxAltaArticulo.TabStop = false;
            // 
            // AltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.pbxAltaArticulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btoCancelar);
            this.Controls.Add(this.btoAceptar);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.codigo);
            this.Name = "AltaArticulo";
            this.Text = "AltaArticulo";
            this.Load += new System.EventHandler(this.AltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAltaArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.Button btoAceptar;
        private System.Windows.Forms.Button btoCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.PictureBox pbxAltaArticulo;
    }
}
namespace Tp_WinForm_Equipo_7A
{
    partial class MasImagenes
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
            this.btn_AgregarImagen = new System.Windows.Forms.Button();
            this.tbo_UrlImagen = new System.Windows.Forms.TextBox();
            this.lv_Imagenes = new System.Windows.Forms.ListView();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AgregarImagen
            // 
            this.btn_AgregarImagen.Location = new System.Drawing.Point(115, 57);
            this.btn_AgregarImagen.Name = "btn_AgregarImagen";
            this.btn_AgregarImagen.Size = new System.Drawing.Size(75, 23);
            this.btn_AgregarImagen.TabIndex = 0;
            this.btn_AgregarImagen.Text = "Agregar";
            this.btn_AgregarImagen.UseVisualStyleBackColor = true;
            this.btn_AgregarImagen.Click += new System.EventHandler(this.btn_AgregarImagen_Click);
            // 
            // tbo_UrlImagen
            // 
            this.tbo_UrlImagen.Location = new System.Drawing.Point(37, 31);
            this.tbo_UrlImagen.Name = "tbo_UrlImagen";
            this.tbo_UrlImagen.Size = new System.Drawing.Size(243, 20);
            this.tbo_UrlImagen.TabIndex = 1;
            // 
            // lv_Imagenes
            // 
            this.lv_Imagenes.HideSelection = false;
            this.lv_Imagenes.Location = new System.Drawing.Point(37, 101);
            this.lv_Imagenes.Name = "lv_Imagenes";
            this.lv_Imagenes.Size = new System.Drawing.Size(243, 251);
            this.lv_Imagenes.TabIndex = 2;
            this.lv_Imagenes.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(37, 409);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 3;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(204, 408);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(330, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 251);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MasImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(611, 463);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lv_Imagenes);
            this.Controls.Add(this.tbo_UrlImagen);
            this.Controls.Add(this.btn_AgregarImagen);
            this.Name = "MasImagenes";
            this.Text = "MasImagenes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AgregarImagen;
        private System.Windows.Forms.TextBox tbo_UrlImagen;
        private System.Windows.Forms.ListView lv_Imagenes;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
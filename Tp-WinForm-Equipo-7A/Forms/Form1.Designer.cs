namespace Tp_WinForm_Equipo_7A
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.btnCargaArticulos = new System.Windows.Forms.Button();
            this.btnModArticulos = new System.Windows.Forms.Button();
            this.btnElimArticulos = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(255, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú Principal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseMnemonic = false;
            // 
            // btnArticulos
            // 
            this.btnArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnArticulos.AutoSize = true;
            this.btnArticulos.BackColor = System.Drawing.Color.Silver;
            this.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulos.Location = new System.Drawing.Point(59, 137);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(137, 67);
            this.btnArticulos.TabIndex = 1;
            this.btnArticulos.Text = "Artículos";
            this.btnArticulos.UseVisualStyleBackColor = false;
            // 
            // btnCargaArticulos
            // 
            this.btnCargaArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCargaArticulos.BackColor = System.Drawing.Color.Silver;
            this.btnCargaArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargaArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargaArticulos.Location = new System.Drawing.Point(244, 137);
            this.btnCargaArticulos.Name = "btnCargaArticulos";
            this.btnCargaArticulos.Size = new System.Drawing.Size(137, 67);
            this.btnCargaArticulos.TabIndex = 2;
            this.btnCargaArticulos.Text = "Agregar Artículos";
            this.btnCargaArticulos.UseVisualStyleBackColor = false;
            // 
            // btnModArticulos
            // 
            this.btnModArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModArticulos.BackColor = System.Drawing.Color.Silver;
            this.btnModArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModArticulos.Location = new System.Drawing.Point(427, 137);
            this.btnModArticulos.Name = "btnModArticulos";
            this.btnModArticulos.Size = new System.Drawing.Size(137, 67);
            this.btnModArticulos.TabIndex = 3;
            this.btnModArticulos.Text = "Modificar Artículos";
            this.btnModArticulos.UseVisualStyleBackColor = false;
            // 
            // btnElimArticulos
            // 
            this.btnElimArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnElimArticulos.BackColor = System.Drawing.Color.Silver;
            this.btnElimArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElimArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimArticulos.Location = new System.Drawing.Point(613, 137);
            this.btnElimArticulos.Name = "btnElimArticulos";
            this.btnElimArticulos.Size = new System.Drawing.Size(137, 67);
            this.btnElimArticulos.TabIndex = 4;
            this.btnElimArticulos.Text = "Eliminar Artículos";
            this.btnElimArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnElimArticulos.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 630);
            this.Controls.Add(this.btnElimArticulos);
            this.Controls.Add(this.btnModArticulos);
            this.Controls.Add(this.btnCargaArticulos);
            this.Controls.Add(this.btnArticulos);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(813, 669);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnCargaArticulos;
        private System.Windows.Forms.Button btnModArticulos;
        private System.Windows.Forms.Button btnElimArticulos;
    }
}


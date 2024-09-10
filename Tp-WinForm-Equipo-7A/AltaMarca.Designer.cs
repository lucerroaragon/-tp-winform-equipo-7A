namespace Tp_WinForm_Equipo_7A
{
    partial class AltaMarca
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
            this.dgv_MarcaNegocio = new System.Windows.Forms.DataGridView();
            this.bnt_Agregar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MarcaNegocio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_MarcaNegocio
            // 
            this.dgv_MarcaNegocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MarcaNegocio.Location = new System.Drawing.Point(25, 44);
            this.dgv_MarcaNegocio.MaximumSize = new System.Drawing.Size(226, 361);
            this.dgv_MarcaNegocio.MinimumSize = new System.Drawing.Size(226, 361);
            this.dgv_MarcaNegocio.Name = "dgv_MarcaNegocio";
            this.dgv_MarcaNegocio.Size = new System.Drawing.Size(226, 361);
            this.dgv_MarcaNegocio.TabIndex = 0;
            // 
            // bnt_Agregar
            // 
            this.bnt_Agregar.Location = new System.Drawing.Point(12, 434);
            this.bnt_Agregar.Name = "bnt_Agregar";
            this.bnt_Agregar.Size = new System.Drawing.Size(75, 23);
            this.bnt_Agregar.TabIndex = 1;
            this.bnt_Agregar.Text = "Agregar";
            this.bnt_Agregar.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(102, 434);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(192, 434);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AltaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 469);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.bnt_Agregar);
            this.Controls.Add(this.dgv_MarcaNegocio);
            this.Name = "AltaMarca";
            this.Text = "AltaMarca";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MarcaNegocio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_MarcaNegocio;
        private System.Windows.Forms.Button bnt_Agregar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button button3;
    }
}
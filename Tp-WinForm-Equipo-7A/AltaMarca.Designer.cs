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
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MarcaNegocio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_MarcaNegocio
            // 
            this.dgv_MarcaNegocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MarcaNegocio.Location = new System.Drawing.Point(27, 58);
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
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(192, 434);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // AltaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 469);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.bnt_Agregar);
            this.Controls.Add(this.dgv_MarcaNegocio);
            this.MaximumSize = new System.Drawing.Size(295, 508);
            this.MinimumSize = new System.Drawing.Size(295, 508);
            this.Name = "AltaMarca";
            this.Text = "AltaMarca";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MarcaNegocio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_MarcaNegocio;
        private System.Windows.Forms.Button bnt_Agregar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Label label1;
    }
}
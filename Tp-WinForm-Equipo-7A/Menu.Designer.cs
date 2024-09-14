namespace Tp_WinForm_Equipo_7A
{
    partial class Menú
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menú));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ctsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(920, 65);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ctsMenu
            // 
            this.ctsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemMenuArticulo,
            this.ItemMenuMarcas,
            this.ItemMenuCategorias});
            this.ctsMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctsMenu.Image = ((System.Drawing.Image)(resources.GetObject("ctsMenu.Image")));
            this.ctsMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ctsMenu.Name = "ctsMenu";
            this.ctsMenu.Size = new System.Drawing.Size(124, 61);
            this.ctsMenu.Text = "&Catalogo";
            // 
            // ItemMenuArticulo
            // 
            this.ItemMenuArticulo.Image = ((System.Drawing.Image)(resources.GetObject("ItemMenuArticulo.Image")));
            this.ItemMenuArticulo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ItemMenuArticulo.Name = "ItemMenuArticulo";
            this.ItemMenuArticulo.Size = new System.Drawing.Size(221, 64);
            this.ItemMenuArticulo.Text = "&Articulos";
            this.ItemMenuArticulo.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // ItemMenuMarcas
            // 
            this.ItemMenuMarcas.Image = ((System.Drawing.Image)(resources.GetObject("ItemMenuMarcas.Image")));
            this.ItemMenuMarcas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ItemMenuMarcas.Name = "ItemMenuMarcas";
            this.ItemMenuMarcas.Size = new System.Drawing.Size(221, 64);
            this.ItemMenuMarcas.Text = "&Marcas";
            this.ItemMenuMarcas.Click += new System.EventHandler(this.ItemMenuMarcas_Click);
            // 
            // ItemMenuCategorias
            // 
            this.ItemMenuCategorias.Image = ((System.Drawing.Image)(resources.GetObject("ItemMenuCategorias.Image")));
            this.ItemMenuCategorias.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ItemMenuCategorias.Name = "ItemMenuCategorias";
            this.ItemMenuCategorias.Size = new System.Drawing.Size(221, 64);
            this.ItemMenuCategorias.Text = "&Categorias";
            this.ItemMenuCategorias.Click += new System.EventHandler(this.ItemMenuCategorias_Click);
            // 
            // Menú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 595);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menú";
            this.Text = "Menú";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctsMenu;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuArticulo;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuMarcas;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuCategorias;
    }
}
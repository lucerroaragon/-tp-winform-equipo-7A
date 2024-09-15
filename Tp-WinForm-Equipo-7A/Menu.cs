using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_WinForm_Equipo_7A
{
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TodosArticulos art = new TodosArticulos();
            art.ShowDialog();
        }

        private void ItemMenuMarcas_Click(object sender, EventArgs e)
        {
            MenuMarca menuMarca = new MenuMarca();
            menuMarca.ShowDialog();
        }

        private void ItemMenuCategorias_Click(object sender, EventArgs e)
        {
            MenuCategoria menuCategoria = new MenuCategoria();
            menuCategoria.ShowDialog();

        }
    }
}

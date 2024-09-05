using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp_WinForm_Equipo_7A.Forms;

namespace Tp_WinForm_Equipo_7A
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
           
        }

        private void btnArticulos_Click(object sender, EventArgs e)

        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType()== typeof(ListaArticulos))
                {
                    MessageBox.Show("La ventana ya esta abierta");
                    return;
                    
                }
            }
            ListaArticulos window = new ListaArticulos();
            window.ShowDialog();
        }

        private void btnModArticulos_Click(object sender, EventArgs e)
        {

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ModificarArticulo))
                {
                    MessageBox.Show("La ventana ya esta abierta");
                    return;

                }
            }
            ModificarArticulo window = new ModificarArticulo();
            window.ShowDialog();

        }

        private void btnElimArticulos_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(EliminarArticulo))
                {
                    MessageBox.Show("La ventana ya esta abierta");
                    return;

                }
            }
            EliminarArticulo window = new EliminarArticulo();
            window.ShowDialog();

        }
    }
}

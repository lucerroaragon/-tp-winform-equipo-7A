using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;

namespace Tp_WinForm_Equipo_7A
{
    public partial class MasImagenes : Form
    {
        
        public MasImagenes()
        {
            InitializeComponent();
        }

        private void btn_AgregarImagen_Click(object sender, EventArgs e)
        {
            lv_Imagenes.Items.Add(tbo_UrlImagen.Text);
        }

        public List<string> ObtenerElementosListView()
        {
            List<string> lista = new List<string>();

            foreach (ListViewItem item in lv_Imagenes.Items)
            {
                lista.Add(item.Text);
            }

            return lista;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            List<string> lista = new List<string>();

            foreach (ListViewItem item in lv_Imagenes.Items)
            {
                lista.Add(item.Text);
            }

            imagenNegocio.obtenerLista(lista);
            Close();
        }
    }
}

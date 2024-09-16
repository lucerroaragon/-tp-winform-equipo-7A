using Dominio;
using Negocio;
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
    public partial class ArticulosDetalles : Form
    {
        private Articulo articulo = null;
        public ArticulosDetalles()
        {
            InitializeComponent();
        }
        public ArticulosDetalles(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Ver Detalles";
        }

        private void ArticulosDetalles_Load(object sender, EventArgs e)
        {
            try
            {

                if (articulo != null)
                {
                    txt_IdArticulo.Text = articulo.IdArticulo.ToString();
                    txt_IdCodigo.Text = articulo.CodArticulo.ToString();
                    txt_Nombre.Text = articulo.Nombre;
                    txt_Descricion.Text = articulo.Descripcion;
                    txt_Precio.Text = articulo.Precio.ToString();
                    cargarImagen(articulo.imagen.Url);
                    txt_Categoria.Text = articulo.categoria.Nombre;
                    txt_Marca.Text = articulo.marca.Nombre;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbx_Imagen.Load(imagen);
            }
            catch (Exception)
            {

                pbx_Imagen.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");

            }
        }
    }
    
}

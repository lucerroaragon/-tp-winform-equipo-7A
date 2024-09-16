using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Tp_WinForm_Equipo_7A
{
    public partial class AltaArticulo : Form
    {
        private Articulo articulo = null;
        private Imagen img = null;

        public AltaArticulo()
        {
            InitializeComponent();
            Text = "Agregar articulo";
        }
        public AltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar articulo";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Los campos del formulario no deben estar vacios.");
                    return;
                }

                if (articulo ==  null)
                    articulo = new Articulo();
                articulo.imagen = new Imagen();

                articulo.CodArticulo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.imagen.Url = txtUrl.Text;
                articulo.categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.marca = (Marca)cboMarca.SelectedItem;
                

                if (articulo.IdArticulo != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitoso");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitoso");
                }
                
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void AltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNogocio categoriaNegocio = new CategoriaNogocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                // Asigna las listas devueltas por los métodos listar a los ComboBox
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboMarca.DataSource = marcaNegocio.listar();

                // Configura las propiedades DisplayMember y ValueMember
                cboCategoria.DisplayMember = "Nombre"; // Campo que se mostrará
                cboCategoria.ValueMember = "IdCategoria"; // Campo que será el valor

                cboMarca.DisplayMember = "Nombre"; // Campo que se mostrará
                cboMarca.ValueMember = "IdMarca"; // Campo que será el valor

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.CodArticulo.ToString();
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    txtUrl.Text = articulo.imagen.Url;
                    cargarImagen(articulo.imagen.Url);
                    cboCategoria.SelectedValue = articulo.categoria.IdCategoria;
                    cboMarca.SelectedValue = articulo.marca.IdMarca;
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrl_Leave(object sender, EventArgs e)
        {

            cargarImagen(txtUrl.Text);

        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxAltaArticulo.Load(imagen);

            }
            catch (Exception)
            {

                pbxAltaArticulo.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");

            }
        }

        private void btn_AgregarMasImagenes_Click(object sender, EventArgs e)
        {
            MasImagenes masImagenes = new MasImagenes();
            masImagenes.ShowDialog();
        }
    }
}

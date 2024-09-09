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
        public AltaArticulo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                nuevo.CodArticulo = txtCodigo.Text;
                nuevo.Nombre = txtNombre.Text;
                nuevo.Descripcion = txtDescripcion.Text;
                nuevo.Precio = decimal.Parse(txtPrecio.Text);
                nuevo.categoria = (Categoria)cboCategoria.SelectedItem;
                nuevo.marca = (Marca)cboMarca.SelectedItem;


                negocio.agregar(nuevo);
                MessageBox.Show("Agregado exitoso");
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
            catch (Exception ex)
            {

                pbxAltaArticulo.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");

            }
        }
    }
}

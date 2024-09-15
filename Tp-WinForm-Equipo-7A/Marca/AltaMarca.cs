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
    public partial class AltaMarca : Form
    {
        private Marca marca= null;
        public AltaMarca()
        {
            InitializeComponent();
        }

        public AltaMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El campo del formulario no debe estar vacio.");
                    return;
                }

                if (marca == null)
                {
                    marca = new Marca();
                }

                marca.Nombre = txtNombre.Text;

               if (marca.IdMarca != 0)
                {
                    marcaNegocio.modificar(marca);
                    MessageBox.Show("Categoría modificada con éxito");
                    this.Close();

                }
                else
                {
                    marcaNegocio.agregar(marca);
                    MessageBox.Show("Categoría modificada con éxito");
                    this.Close();
                }

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

           


        }

        private void AltaMarca_Load(object sender, EventArgs e)
        {
            try
            {
                if (marca != null)
                {
                    txtNombre.Text = marca.Nombre;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

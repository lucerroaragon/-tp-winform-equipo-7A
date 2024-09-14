using Dominio;
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

namespace Tp_WinForm_Equipo_7A
{
    public partial class AltaCategoria : Form
    {
        private Categoria categoria = null;
        public AltaCategoria()
        {
            InitializeComponent();
            
        }
        public AltaCategoria(Categoria categoria):this()
        {
           
            this.categoria = categoria;
            Text = "Modificar Categoria";


        }

        private void AltaCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                if (categoria != null)
                {

                    txtNombre.Text = categoria.Nombre;


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
           CategoriaNogocio categoriaNegocio = new CategoriaNogocio();

            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre de la categoría no puede estar vacío.");
                    return; 
                }

               
                if (categoria == null)
                {
                   
                    categoria = new Categoria();
                }
              
                categoria.Nombre = txtNombre.Text;

                
                if (categoria.IdCategoria != 0)
                {
                    categoriaNegocio.modificar(categoria);
                    MessageBox.Show("Categoría modificada con éxito");
                    this.Close();
                }
                else
                {
                    
                    categoriaNegocio.agregar(categoria);
                    MessageBox.Show("Categoría agregada con éxito");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
       
        }

        
    }
}



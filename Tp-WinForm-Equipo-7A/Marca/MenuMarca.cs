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
    public partial class MenuMarca : Form
    {
        private List<Marca> listaMarca;
        public MenuMarca()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaMarca agregarMarca = new AltaMarca();
            agregarMarca.ShowDialog();
            Cargar();

        }

        private void MenuMarca_Load(object sender, EventArgs e)
        {
            Cargar();

        }

        public void Cargar() {             
           MarcaNegocio negocio = new MarcaNegocio();

            try
            {
              listaMarca = negocio.listar();
                dgvMarca.DataSource = listaMarca;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Marca selecionado;
            selecionado = (Marca)dgvMarca.CurrentRow.DataBoundItem;
            AltaMarca modificar= new AltaMarca(selecionado);

            modificar.ShowDialog();
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {          
             MarcaNegocio negocio = new MarcaNegocio();
             Marca seleccionado;
             try
             {
                DialogResult respuesta = MessageBox.Show("Vamos a liminar el articulo, ¿Estas seguro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                   seleccionado = (Marca)dgvMarca.CurrentRow.DataBoundItem;
                   negocio.eliminar(seleccionado.IdMarca);
                   Cargar();
                }
             }
             catch (Exception ex)
             {
                    MessageBox.Show(ex.ToString());
             }
            
        }
    }
}

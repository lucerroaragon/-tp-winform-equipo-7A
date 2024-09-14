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
    public partial class MenuCategoria : Form
    {
        private List<Categoria> listaCategoria;
        public MenuCategoria()
        {
            InitializeComponent();
        }

        private void MenuCategoria_Load(object sender, EventArgs e)
        {
            Cargar();

            

        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaCategoria altaCategoria = new AltaCategoria();
            altaCategoria.ShowDialog();
            Cargar();
        }
    

        public void Cargar()
        {
            CategoriaNogocio categoria = new CategoriaNogocio();
            try
            {
                listaCategoria = categoria.listar();
                dvgCategoria.DataSource = listaCategoria;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Categoria seleccionado;
            seleccionado = (Categoria)dvgCategoria.CurrentRow.DataBoundItem;
            AltaCategoria modificar = new AltaCategoria(seleccionado);
            
            modificar.ShowDialog();               
            Cargar();           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CategoriaNogocio negocio = new CategoriaNogocio();
            Categoria seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Vamos a liminar el articulo, ¿Estas seguro?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Categoria)dvgCategoria.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.IdCategoria);
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

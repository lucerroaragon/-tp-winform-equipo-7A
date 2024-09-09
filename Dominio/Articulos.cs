using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Dominio
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        [DisplayName("Código")]
        public string CodArticulo { get; set; }
        public string Nombre { get; set; }
        [DisplayName ("Descripción")]
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        [DisplayName("Marca")]
        public Marca marca { get; set; }
        [DisplayName("Categoria")]
        public Categoria categoria { get; set; }
        public List<Imagen> Imagenes { get; set; }

        // Propiedad para la URL de la primera imagen
        public string ImagenUrl
        {
            get
            {
                return Imagenes != null && Imagenes.Count > 0 ? Imagenes[0].Url : null;
            }



        }


    }
}

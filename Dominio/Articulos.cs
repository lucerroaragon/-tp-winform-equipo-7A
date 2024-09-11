﻿using System;
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
        public Imagen imagen { get; set; }

    }
}

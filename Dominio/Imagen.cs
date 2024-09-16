﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Imagen
    {
        public int Id { get; set; }  
        public int IdArticulo { get; set; }  
        public string Url { get; set; }
        public List<Imagen> imagenes { get; set; }

        public override string ToString()
        {
            return Url;
        }
    }

 
}

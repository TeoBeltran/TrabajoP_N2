﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_WinForm
{
    public class Articulo
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca IdMarca { get; set; }
        public Categoria IdCategoria { get; set; }
        //public string img { get; set; }
        public decimal Precio { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre{ get; set; }
        public string  Descripcion { get; set; }
        public decimal Precio{ get; set; }

    }
}
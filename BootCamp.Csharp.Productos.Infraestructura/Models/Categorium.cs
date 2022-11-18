﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BootCamp.Csharp.Productos.Infraestructura.Models
{
    public partial class Categorium
    {
        public Categorium()
        {
            Productos = new HashSet<Producto>();
        }

        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace BootCamp.Csharp.Productos.Infraestructura.Models
{
    public partial class Subcategorium
    {
        public Subcategorium()
        {
            Productos = new HashSet<Producto>();
        }

        public int IdSubcategoria { get; set; }
        public string NombreSubcategoria { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}

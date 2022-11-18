using System;
using System.Collections.Generic;

#nullable disable

namespace BootCamp.Csharp.Productos.Infraestructura.Models
{
    public partial class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public decimal? Stock { get; set; }
        public int? Categoria { get; set; }
        public int? Subcategoria { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Peso { get; set; }

        public virtual Categorium CategoriaNavigation { get; set; }
        public virtual Subcategorium SubcategoriaNavigation { get; set; }
    }
}

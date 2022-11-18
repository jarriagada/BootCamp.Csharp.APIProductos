using BootCamp.Csharp.Productos.Infraestructura.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Csharp.Productos.Domain
{
    public class Calculos
    {
        public void EliminarProducto(Producto Productos)
        {
            using (var Context = new ProductosWebContext())
            {
                var Entidad = Context.Productos.Where(a => a.IdProducto == Productos.IdProducto);
                Context.Productos.Remove((Producto)Entidad);
                Context.SaveChanges();  
            }
        }


        public IList<Producto> LeerProducto()
        {
            using (var Context = new ProductosWebContext())
            {
                //var ListaEntidades = new List<Producto>();
                var Entidades = Context.Productos.ToList();

                //foreach (var item in Entidades)
                //{
                //    ListaEntidades.Add(item);
                //}
                return Entidades;
            }
        }

    }

}

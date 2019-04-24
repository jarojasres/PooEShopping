using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PooEShopping.Models
{
    public static class DbInitializer
    {
        public static void Seed(PooEShoppingContext context)
        {

            if (!context.Categorias.Any())
            {
                context.Categorias.AddRange(new List<Categoria>
                {
                    new Categoria { Nombre = "Categoría 1", Descripcion = "Categoría 1"},
                    new Categoria { Nombre = "Categoría 2", Descripcion = "Categoría 2"},
                    new Categoria { Nombre = "Categoría 3", Descripcion = "Categoría 3"},
                    new Categoria { Nombre = "Categoría 4", Descripcion = "Categoría 4"}
                });

                context.SaveChanges();
            }
        }
    }
}

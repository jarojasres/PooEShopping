using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PooEShopping.Models
{
    public class PooEShoppingContext : DbContext
    {
        public PooEShoppingContext(DbContextOptions<PooEShoppingContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PooEShopping.Models
{
    public class CategoriaDAO : ICategoriaDAO
    {
        private readonly PooEShoppingContext _context;

        public CategoriaDAO(PooEShoppingContext context)
        {
            _context = context;
        }
        public void Agregar(Categoria categoria)
        {
            _context.Add(categoria);
            _context.SaveChanges();
        }

        public void Eliminar(Categoria categoria)
        {
            _context.Set<Categoria>().Remove(categoria);
            _context.SaveChanges();
        }

        public void Modificar(Categoria categoria)
        {
            _context.Set<Categoria>().Update(categoria);
            _context.SaveChanges();
        }

        public Categoria ObtenerPorId(int id)
        {
            return _context.Categorias.Find(id);
        }

        public List<Categoria> ObtenerTodas()
        {
            return _context.Categorias.ToList();
        }
    }
}

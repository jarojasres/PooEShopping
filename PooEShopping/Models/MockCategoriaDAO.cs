using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PooEShopping.Models
{
    public class MockCategoriaDAO : ICategoriaDAO
    {
        private List<Categoria> _categorias;
        public MockCategoriaDAO()
        {
            if(_categorias == null)
            {
                InicializarCategorias();
            }

        }
        public void Agregar(Categoria categoria)
        {
            _categorias.Add(categoria);
        }

        public void Eliminar(Categoria categoria)
        {
            _categorias.Remove(categoria);
        }

        public void Modificar(Categoria categoria)
        {
            var categoriaAlmacenada = _categorias.FirstOrDefault(c => c.Id == categoria.Id);
            _categorias.Remove(categoriaAlmacenada);
            _categorias.Add(categoria);

        }

        public Categoria ObtenerPorId(int id)
        {
            return _categorias.FirstOrDefault(c => c.Id == id);
        }

        public List<Categoria> ObtenerTodas()
        {
            return _categorias;
        }

        private void InicializarCategorias()
        {
            _categorias = new List<Categoria>
            {
                new Categoria { Id = 1, Nombre = "Categoría 1", Descripcion = "Categoría 1"},
                new Categoria { Id = 2, Nombre = "Categoría 2", Descripcion = "Categoría 2"},
                new Categoria { Id = 3, Nombre = "Categoría 3", Descripcion = "Categoría 3"},
                new Categoria { Id = 4, Nombre = "Categoría 4", Descripcion = "Categoría 4"}
            };
        }
    }
}

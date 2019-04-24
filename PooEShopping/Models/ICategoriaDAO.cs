using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PooEShopping.Models
{
    public interface ICategoriaDAO
    {
        void Agregar(Categoria categoria);
        void Modificar(Categoria categoria);
        void Eliminar(Categoria categoria);
        List<Categoria> ObtenerTodas();

        Categoria ObtenerPorId(int id);
    }
}

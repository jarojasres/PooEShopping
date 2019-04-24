using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PooEShopping.Models;

namespace PooEShopping.Controllers
{
    public class AdminCategoriasController : Controller
    {
        private readonly ICategoriaDAO _categoriaDAO;

        public AdminCategoriasController(ICategoriaDAO categoriaDAO)
        {
            _categoriaDAO = categoriaDAO;
        }
        public IActionResult Listar()
        {
            var categorias = _categoriaDAO.ObtenerTodas();
            return View(categorias);
        }

        public IActionResult Modificar(int id)
        {
            var categoria = _categoriaDAO.ObtenerPorId(id);
            return View(categoria);
        }

        [HttpPost]
        public IActionResult Modificar(Categoria categoria)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _categoriaDAO.Modificar(categoria);
                    ViewData["Mensaje"] = $"La categoría [{categoria.Nombre}] fue editada exitosamente";
                }
                else
                {
                    return View(categoria);
                }
            }
            catch (Exception ex)
            {
                ViewData["Mensaje"] = $"La categoría [{categoria.Nombre}] no pudo ser editada";
            }
            return RedirectToAction("Listar");
        }

        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Categoria categoria)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _categoriaDAO.Agregar(categoria);
                    ViewData["Mensaje"] = $"La categoría [{categoria.Nombre}] fue guardada exitosamente";
                }
                return View(categoria);
            }
            catch (Exception ex)
            {
                ViewData["Mensaje"] = $"La categoría [{categoria.Nombre}] no pudo ser guardada";
            }
            return RedirectToAction("Listar");
        }

        public IActionResult Eliminar(int id)
        {
            var categoria = _categoriaDAO.ObtenerPorId(id);
            _categoriaDAO.Eliminar(categoria);

            return RedirectToAction("Listar");
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Clientes.Data;
using Clientes.ViewModels;
using Clientes.Models;

namespace Clientes.Controllers
{
    public class ProductosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Productos()
        {
            var productos = _context.Productos
                .Select(p => new ProductoVM
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Descripcion = p.Descripcion,
                    Precio = p.Precio,
                    Existencia = p.Existencia
                })
                .ToList();

            return View(productos);
        }
    }
}


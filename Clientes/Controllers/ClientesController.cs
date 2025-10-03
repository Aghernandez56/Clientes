using Microsoft.AspNetCore.Mvc;
using Clientes.Data;
using Clientes.ViewModels;
using Clientes.Models;

namespace Clientes.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Clientes()
        {
            var clientes = _context.Clientes
                .Select(c => new ClienteVM
                {
                    Id = c.Id,
                    Nombre = c.Nombre,
                    ApellidoPaterno = c.ApellidoPaterno,
                    ApellidoMaterno = c.ApellidoMaterno,
                    Telefono = c.Telefono
                })
                .ToList();

            return View(clientes);
        }
    }
}

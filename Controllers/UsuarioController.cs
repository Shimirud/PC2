using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using pc2.Data;
using pc2.Models;

namespace pc2.Controllers
{
    public class UsuarioController : Controller
    {
        private EmpresaContext _context;
        public PokemonController(EmpresaContext context)
        {
            _context = context;
        }

        public IActionResult Nuevo() {
            return View();
        }

        [HttpPost]
        public IActionResult Nuevo(Usuario u) {
            if (ModelState.IsValid) {
                _context.Add(p);
                _context.SaveChanges();
                
                return RedirectToAction("Datos");
            }
            
            return View(u);
        }

        public IActionResult Datos() {
            var datos = _context.Datos.ToList();
            return View(datos);
        }
    }
}
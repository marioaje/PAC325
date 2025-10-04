using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoFront.Data;
using ProyectoFront.Models;

namespace ProyectoFront.Controllers
{
    public class ProductosController : Controller
    {

        //Invocar o hacer una instancia
        private readonly AppDbContext _context;

        //Instanciarme
        public ProductosController (AppDbContext context)
        {
            _context = context;
        }


        //Los metodos ahora son asyncronicos
        public async Task<IActionResult> Index()
        {
            return View( await _context.Producto.ToListAsync());
        }


        //Crear???

        public IActionResult Crear()
        {

            return View();
        }

        //Post
        [HttpPost]
        public async Task<IActionResult> Crear(ProductoModel _producto)
        {

            if (ModelState.IsValid)
            {

                _context.Add(_producto);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }


            return View(_producto);
        }
    }
}

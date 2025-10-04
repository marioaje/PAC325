using Microsoft.AspNetCore.Mvc;
using ProyectoFront.Data;

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



        public IActionResult Index()
        {
            return View();
        }
    }
}

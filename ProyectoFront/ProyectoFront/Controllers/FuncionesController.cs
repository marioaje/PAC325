using Microsoft.AspNetCore.Mvc;

namespace ProyectoFront.Controllers
{
    public class FuncionesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

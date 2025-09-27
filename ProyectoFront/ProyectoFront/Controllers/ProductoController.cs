using Microsoft.AspNetCore.Mvc;
using ProyectoFront.Models;

namespace ProyectoFront.Controllers
{
    public class ProductoController : Controller
    {

        //Propiedades y variables
        //public int Id { get; set; }

        //public string Nombre { get; set; }
        //public string Descripcion { get; set; }
        //public decimal Precio { get; set; }
        //public int Cantidad { get; set; }
        private static List<Producto> _productos = new List<Producto>()
        {
            new Producto{ Id=1, Nombre="Producto 1", Descripcion="Tabla", Precio= 1000, Cantidad=20 },
            new Producto{ Id=2, Nombre="Producto 2", Descripcion="Tabla", Precio=1000, Cantidad=20 },
        };
        private static int _siguienteIndice = 3;
        //Get
        public IActionResult Index()
        {
            
            return View(_productos);
        }

        //Get
        public IActionResult Crear()
        {

            return View();
        }
        //Post
        [HttpPost]
        public IActionResult Crear(Producto _producto)
        {

            if (ModelState.IsValid)
            {
                _producto.Id = _siguienteIndice++;

                _productos.Add(_producto);

                return RedirectToAction("Index");
            }


            return View(_producto);
        }

    }
}

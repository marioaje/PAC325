using API.Model;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Timers;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : Controller
    {
        private readonly ProductoSerice _productoSerice;


        public ProductosController(ProductoSerice productoSerice)
        {
            _productoSerice = productoSerice;
        }
        //El controller une la vista con la logica 
        //CRUD POST/GET/PUT/DELETE

        //GetProducto()

        [HttpGet]
        public ActionResult<IEnumerable<ProductoModel>> GetProducto()
        {
            return _productoSerice.GetProducto();
        }

        [HttpPost]
        public ActionResult PostProducto(ProductoModel _productoModel) {

            ProductoModel newProducto = _productoSerice.PostProducto(_productoModel);


            return CreatedAtAction(
                    nameof(GetProducto),
                    new
                        {
                            id = newProducto.Id,
                        },
                        newProducto );

        }
    }
}

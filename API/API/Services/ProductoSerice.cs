using API.Data;
using API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace API.Services
{
    public class ProductoSerice
    {
        private readonly AppDbContext _context;
        

        //El iniciador???
        public ProductoSerice(AppDbContext context)
        {
            _context = context;
        }

        //Funcion de obtener datos
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Producto.ToListAsync());
        //}
        //GET
        public List<ProductoModel> GetProducto()
        {
            return _context.Producto.ToList();
        }
        //POST
        public ProductoModel PostProducto(ProductoModel _productoModel)
        {
            //                 _context.Add(_producto);
            //await _context.SaveChangesAsync();
            _context.Producto.Add(_productoModel);
            _context.SaveChanges();

            return _productoModel;

        }


    }
}

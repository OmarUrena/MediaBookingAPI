//using MediaBookingAPI.Data;
//using MediaBookingAPI.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace MediaBookingAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProductoController : ControllerBase
//    {
//        private readonly BDContext _context;

//        public ProductoController(BDContext context)
//        {
//            _context = context;
//        }

//        // GET: api/Producto
//        [HttpGet]
//        public async Task<IActionResult> GetProducto()
//        {
//            var productos = await _context.Producto
//                .Select(r => new {
//                    id = r.Id,
//                    idtipo = r.IdTipoProducto,
//                    nombre = r.Nombre,
//                    descripcion = r.Descripcion,
//                    nombreTipoProducto = r.TipoProducto.nombre 
//                })
//                .ToListAsync();

//            return Ok(productos);
//        }
//    }
//}

using MediaBookingAPI.Data;
using MediaBookingAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediaBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly BDContext _context;

        public ProductoController(BDContext context)
        {
            _context = context;
        }

        // GET: api/Producto
        /* [HttpGet]
        public async Task<IActionResult> GetProducto()
        {
            // Es importante asegurar que incluyas la relación TipoProducto para evitar errores de referencia nula.
            var productos = await _context.Producto
                .Include(p => p.TipoProducto)  // Asegura que el TipoProducto esté cargado para evitar errores de referencia nula.
                .Select(p => new {
                    id = p.Id,
                    idtipo = p.IdTipoProducto,
                    nombre = p.Nombre,
                    descripcion = p.Descripcion,
                    nombreTipoProducto = p.TipoProducto != null ? p.TipoProducto.nombre : null  // Manejo seguro en caso de que TipoProducto sea nulo.
                })
                .ToListAsync();

            return Ok(productos);
        } */

        [HttpPost]

        public async Task<IActionResult> CreateProducto([FromBody] Producto producto)
        {
            Console.WriteLine("Working");
            _context.Producto.Add(producto);
            Console.WriteLine(_context.Producto);
            Console.WriteLine(producto);
            await _context.SaveChangesAsync();

            return Created("", producto);
        }
    }
}


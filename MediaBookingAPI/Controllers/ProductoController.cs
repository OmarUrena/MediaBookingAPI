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
        [HttpGet]
        public async Task<IActionResult> GetProducto()
        {
            var productos = await _context.Producto
                .Select(r => new {
                    id = r.Id,
                    idtipo = r.IdTipoProducto,
                    nombre = r.Nombre,
                    descripcion = r.Descripcion,
                    nombreTipoProducto = r.TipoProducto.nombre 
                })
                .ToListAsync();

            return Ok(productos);
        }
    }
}

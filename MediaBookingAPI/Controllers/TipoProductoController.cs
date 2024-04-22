using MediaBookingAPI.Data;
using MediaBookingAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediaBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoProductoController : Controller
    {
        private readonly BDContext _context;

        public TipoProductoController(BDContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoProducto>>> GetTipoProductos()
        {
            return await _context.TipoProducto.ToListAsync();
        }

        // PUT: api/TipoProductos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoProducto(int id, TipoProducto tipoProducto)
        {
            if (id != tipoProducto.id)
            {
                return BadRequest();
            }

            _context.Entry(tipoProducto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoProductoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool TipoProductoExists(int id)
        {
            return _context.TipoProducto.Any(e => e.id == id);
        }
    }
}


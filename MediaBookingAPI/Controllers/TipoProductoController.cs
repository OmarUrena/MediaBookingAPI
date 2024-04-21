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
    }
}

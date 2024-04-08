using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediaBookingAPI.Models;
using MediaBookingAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace MediaBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservacionesController : ControllerBase
    {
        private readonly BDContext _context;

        public ReservacionesController(BDContext context)
        {
            _context = context;
        }
        //GET: api/Reservaciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reservaciones>>> GetReservaciones()
        {
            return await _context.Reservaciones.ToListAsync();
        }
    }
}

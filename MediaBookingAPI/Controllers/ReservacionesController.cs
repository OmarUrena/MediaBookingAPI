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
        //public async Task<ActionResult<IEnumerable<Reservaciones>>> GetReservaciones()
        //{
        //    return await _context.Reservaciones.ToListAsync();
        //}

        public async Task<IActionResult> GetReservaciones()
        {
            var reservaciones = await _context.Reservaciones
                .Include(r => r.Usuario)
                .Include (r => r.Producto)
                .Select(r => new {
                    IdReservacion = r.id_reservacion,
                    NombreUsuario = r.Usuario.nombre,
                    NombreMateria = r.nombre_materia,
                    NombreProducto = r.Producto.nombre_producto,
                    TelefonoReservacion = r.telefono_reservacion,
                    HoraInicioReservacion = r.hora_inicio_reservacion,
                    HoraFinalReservacion = r.hora_final_reservacion,
                    CorreoReservacion = r.correo_reservacion,
                })
                .ToListAsync();

            return Ok(reservaciones);
        }
    }
}

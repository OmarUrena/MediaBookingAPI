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

        public async Task<IActionResult>GetReservaciones()
        {
            var reservaciones = await _context.Reservaciones
                .Include(r => r.Usuario)
                .Include(r => r.Producto)
                .Include(r => r.Auxiliar)
                .Include(r => r.Materias)
                .Select(r => new
                {
                    id = r.id,
                    matricula = r.Usuario.usuario,
                    nombreestudiante = r.Usuario.nombre,
                    nombreproducto = r.Producto.Nombre,
                    codigos = r.Materias.codigo,
                    nombremateria = r.Materias.nombre,
                    curso = r.Materias.curso,
                    fecharegistro = r.fechareserva,
                    horainicial = r.Materias.horainicio,
                    horafin = r.Materias.horafin,
                    estatuse = r.estatus,
                    nombreauxiliar = r.Auxiliar.nombre   

                }) .ToArrayAsync();

            return Ok(reservaciones);
        }
    }
}

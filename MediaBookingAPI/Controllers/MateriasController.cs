using MediaBookingAPI.Data;
using MediaBookingAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediaBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriasController : ControllerBase
    {
        private readonly BDContext _context;

        public MateriasController(BDContext context)
        {
            _context = context;
        }


        [HttpGet]

        public async Task<IActionResult> GetMaterias()
        {
            var materias = await _context.materia.Include(m => m.Usuario)
                .Select(m=> new {
                    MateriaId = m.id_materia,
                    MateriaNombre = m.nombre_materia,
                    Profesor = m.profesor_materia,
                    IdUsuario = m.id_usuario,
                    NombreUsuario = m.Usuario.usuario,
                    Dia = m.dia_materia,
                    HoraInicio = m.hora_incial_materia,
                    HoraFin = m.hora_final_materia,
                    Curso = m.curso_materia
                
                }
                ).ToListAsync();

            return Ok(materias);
        }
        
        
    }
}

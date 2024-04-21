using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediaBookingAPI.Models;
using MediaBookingAPI.Data;
using Microsoft.EntityFrameworkCore;


namespace MediaBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {

        private readonly BDContext _context;

        public UsuariosController(BDContext context)
        {
            _context = context;
        }

        // GET: api/usuarios

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var usuario = await _context.Usuario.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            return await _context.Usuario.ToListAsync();
        }

        [HttpPost]

        public async Task<IActionResult> CreateUsuario([FromBody] Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            await _context.SaveChangesAsync();

            return Created("", usuario);
        }
    }
}

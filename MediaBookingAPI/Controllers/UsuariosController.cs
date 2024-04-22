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

        [HttpPost("authenticate")]
        public async Task<ActionResult<Usuario>> Authenticate([FromBody] Acceso login)
        {
            var usuario = await _context.Usuario
                .SingleOrDefaultAsync(u => u.usuario == login.Username && u.clave == login.Password);

            if (usuario == null)
            {
                return Unauthorized(new { message = "Usuario o contraseña incorrecta" });
            }

            return usuario; // En un caso real, deberías devolver solo datos seguros o un token JWT
        }

        // PUT: api/usuarios
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(int id, Usuario usuario)
        {
            if (id != usuario.id)
            {
                return BadRequest();
            }

            _context.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
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

        private bool UsuarioExists(int id)
        {
            return _context.Usuario.Any(e => e.id == id);
        }
    }
}





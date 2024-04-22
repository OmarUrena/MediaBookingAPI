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

        public async Task<ActionResult<IEnumerable<Materias>>> GetMaterias()
        {
            return await _context.Materia.ToListAsync();
        }
      
      
    }
}

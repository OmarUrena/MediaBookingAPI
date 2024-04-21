using MediaBookingAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[Controller]")]
[ApiController]
public class InventarioController : Controller
{
    private readonly BDContext _context;

    public InventarioController(BDContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetInventario()
    {
        var inventarios = await _context.Inventario
            .Include(r => r.Producto)
            .Select(r => new {
                id = r.id,
                idproducto = r.idproducto,
                cantidad = r.cantidad,
                nombreProducto = r.Producto.Nombre 
            })
            .ToListAsync();

        return Ok(inventarios);
    }
}

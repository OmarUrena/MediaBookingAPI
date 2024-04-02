using Microsoft.EntityFrameworkCore;
using MediaBookingAPI.Models;

namespace MediaBookingAPI.Data
{
    public class BDContext : DbContext
    {
        public BDContext(DbContextOptions<BDContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        


    }
}

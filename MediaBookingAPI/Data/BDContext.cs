using Microsoft.EntityFrameworkCore;
using MediaBookingAPI.Models;

namespace MediaBookingAPI.Data
{
    public class BDContext : DbContext
    {
        public BDContext(DbContextOptions<BDContext> options) : base(options) { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Reservaciones> Reservaciones { get; set; }
        public DbSet<TipoProducto> TipoProducto { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Materias> materia { get; set; }

        public DbSet<Inventario> Inventario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>()
               .HasOne(p => p.TipoProducto)
               .WithMany()
               .HasForeignKey(p => p.IdTipoProducto) // Esto debería estar bien si coincide con tu anotación
               .HasConstraintName("FK_Producto_TipoProducto_IdTipoProducto"); // Opcional, añade claridad

            modelBuilder.Entity<Inventario>()
               .HasOne(i => i.Producto)
               .WithMany(p => p.inventario) 
               .HasForeignKey(i => i.idproducto); 
        }


    }
}

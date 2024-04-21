using MediaBookingAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Inventario
{
    [Key]
    public int id { get; set; }

    [Column("Cantidad")]
    public int cantidad { get; set; }

    [Column("IdProducto")]
    public int? idproducto { get; set; }

    [ForeignKey("IdProducto")] 
    public virtual Producto Producto { get; set; }
}

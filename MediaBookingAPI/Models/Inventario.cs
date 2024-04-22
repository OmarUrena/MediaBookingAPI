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


    //Llaves foraneas para poder utilizar los campos de tipoproducto, Esto crea una instancia para crear las relaciones.
    [ForeignKey("IdProducto")] 
    public Producto Producto { get; set; }
}

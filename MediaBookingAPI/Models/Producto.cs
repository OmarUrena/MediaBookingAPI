using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaBookingAPI.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Column("Nombre")] //Asegurando que tenga el mismo nombre de la columna de la tabla.
        public string Nombre { get; set; }

        [Column("Descripcion")]
        public string Descripcion { get; set; }
        [ForeignKey("IdTipoProducto")]
        [Column("IdTipoProducto")]
        public int IdTipoProducto { get; set; }

        [Column ("FechaRegistro")]

        public DateTime FechaRegistro {  get; set; }


        //Llaves foraneas para poder utilizar los campos de tipoproducto, Esto crea una instancia para crear las relaciones.
        [ForeignKey("IdTipoProducto")]
        public TipoProducto TipoProducto { get; set; }
        
    }

}

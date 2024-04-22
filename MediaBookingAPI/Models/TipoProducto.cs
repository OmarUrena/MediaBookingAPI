using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaBookingAPI.Models
{
    public class TipoProducto
    {
        [Key]
        public int id { get; set; }

        [Column("Nombre")]
        public string nombre { get; set; }

        [Column("Descripcion")]
        public string descripcion { get; set; }

    }

}


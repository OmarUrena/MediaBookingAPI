using System.ComponentModel.DataAnnotations;

namespace MediaBookingAPI.Models
{
    public class Productos
    {
        [Key]
        public int id_producto { get; set; }
        public string nombre_producto { get; set; }
        public string descripcion_producto { get; set; }
        public int id_tipo_producto { get; set; }    
        public DateOnly fecha_producto { get; set; }

    }
}

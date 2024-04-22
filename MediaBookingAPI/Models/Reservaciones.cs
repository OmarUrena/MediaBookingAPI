using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaBookingAPI.Models
{
    public class Reservaciones
    {
        [Key]
        public int id_reservacion { get; set; }
        [ForeignKey("Usuario")]
        public int id_usuario { get; set; }
        public virtual Usuario Usuario { get; set; }
        public string nombre_materia { get; set; }
        [ForeignKey("Producto")]
        public int id_producto { get; set; }
        public virtual Producto Producto { get; set; }
        public string telefono_reservacion { get; set; }
        public DateTime hora_inicio_reservacion { get; set; }
        public DateTime hora_final_reservacion { get; set; }
        public string correo_reservacion { get; set; }

    }
}

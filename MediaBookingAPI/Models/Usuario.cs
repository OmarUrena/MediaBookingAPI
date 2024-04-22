using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaBookingAPI.Models
{
    public class Usuario
    {

        [Key]
        public int id { get; set; }
       
        public string usuario {  get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string clave { get; set; }
        public string telefono { get; set; }
        public string correo {  get; set; }
        public string direccion { get; set; }
        public string rol { get; set; }

        [Column("FechaRegistro")]
        public DateTime registro { get; set; }


    }
}

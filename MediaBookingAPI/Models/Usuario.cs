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

<<<<<<< HEAD
        //public virtual ICollection<Materias> Materias { get; set; }
=======
        public string clave_usuario { get; set; }

        public string telefono_usuario { get; set; }

        public string correo_usuario {  get; set; }

        public string direccion_usuario { get; set; }
        public string tipo_usuario { get; set; }

        
>>>>>>> e7463517caeb6b83abac1ecfb644e88f3b053cb3

    }
}

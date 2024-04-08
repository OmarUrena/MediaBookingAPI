using System.ComponentModel.DataAnnotations;

namespace MediaBookingAPI.Models
{
    public class Usuario
    {

        [Key]
        public int id_usuario { get; set; }
       
        public string usuario {  get; set; }
        public string nombre_usuario { get; set; }

        public string apellido_usuario { get; set; }

        public string clave_usuario { get; set; }

        public string telefono_usuario { get; set; }

        public string correo_usuario {  get; set; }

        public string direccion_usuario { get; set; }
        public string tipo_usuario { get; set; }

    }
}

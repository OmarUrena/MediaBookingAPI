using System.ComponentModel.DataAnnotations;

namespace MediaBookingAPI.Models
{
    public class Usuario
    {

        [Key]
        public int Id_user { get; set; }
       
        public string User {  get; set; }
        public string Nombre_user { get; set; }

        public string Apellido_user { get; set; }

        public string Correo_user { get; set; }

        public string Telefono_user { get; set; }

        public string Direccion_user {  get; set; }

        public string Contrasena_user { get; set; }

    }
}

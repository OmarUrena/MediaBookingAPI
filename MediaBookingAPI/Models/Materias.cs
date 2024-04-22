using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaBookingAPI.Models
{
    public class Materias
    {

        [Key]
        public int id { get; set; }

        [Column("Codigo")]
        public string codigo { get; set; }

        [Column("Nombre")]
        public string nombre { get; set; }

        [Column("Dia")]
        public string dia {  get; set; }

        [Column("HoraInicio")]
        public TimeOnly horainicio { get; set; }

        [Column("HoraFin")]
        public TimeOnly horafin {  get; set; }

        [Column("IdProfesor")]
        public int idprofesor {  get; set; }

        [Column("IdEstudiante")]
        public int idestudiante { get; set; }

        [Column("Curso")]
        public string curso { get; set; }



    }
}

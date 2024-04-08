using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaBookingAPI.Models
{
    public class Materias
    {

        [Key]

        public string id_materia { get; set; }

        public string nombre_materia { get; set; }

        public string profesor_materia { get; set; }

        [ForeignKey("Usuario")]
        public int id_usuario { get; set; }

        public string dia_materia { get; set; }

        public TimeOnly hora_incial_materia { get; set; }

        public TimeOnly hora_final_materia { get; set; }

        public string curso_materia { get; set; }

        public Usuario Usuario { get; set;}
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaBookingAPI.Models
{
    public class Reservaciones
    {
        [Key]
        public int id { get; set; }

        [Column("IdSolicitante")]
        public int? idsolicitante { get; set; }

        [Column("IdMateria")]
        public int? idmateria { get; set; }

        [Column("IdProducto")]
        public int? idproducto { get; set; }

        [Column("Estatus")]
        public string estatus { get; set; }

        [Column("IdAuxiliar")]
        public int? idauxiliar { get; set; }

        [Column("Codigo")]
        public string codigo { get; set; }

        [Column("FechaReserva")]
        public DateOnly fechareserva { get; set; }


        //Llaves foraneas para poder utilizar los campos de tipoproducto, Esto crea una instancia para crear las relaciones.
        [ForeignKey("IdSolicitante")]
        public Usuario Usuario { get; set; }
        [ForeignKey("IdMateria")]
        public  Materias Materias { get; set; }
        [ForeignKey("IdProducto")]
        public  Producto Producto { get; set; }
        [ForeignKey("IdAuxiliar")]
        public  Usuario Auxiliar { get; set; }



    }
}

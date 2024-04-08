﻿using System.ComponentModel.DataAnnotations;

namespace MediaBookingAPI.Models
{
    public class Reservaciones
    {
        [Key]
        public int id_reservacion { get; set; }
        public int id_usuario { get; set; } 
        public string nombre_materia { get; set; }  
        public int id_producto { get; set; }
        public string telefono_reservacion { get; set; }
        public DateTime hora_inicio_reservacion { get; set; }
        public DateTime hora_final_reservacion { get; set; }
        public string correo_reservacion { get; set; }

    }
}
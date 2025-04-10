using PetCare.API.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace PetCare.Models
{
    public class Cita
    {
        [Key]
        public int IdCita { get; set; }

        [Required]
        public System.DateTime FechaHora { get; set; }

        // Relación: cada cita se asocia a una mascota.
        [ForeignKey("Mascota")]
        public int IdMascota { get; set; }
        public Mascota Mascota { get; set; }

        // Relación: cada cita tiene un servicio asignado.
        [ForeignKey("Servicio")]
        public int IdServicio { get; set; }
        public Servicio Servicio { get; set; }

        // Relación muchos a muchos: productos asociados a la cita.
        [JsonIgnore]
        public List<CitaProducto> CitaProductos { get; set; } = new List<CitaProducto>();

        // Métodos de negocio
        public void Agendar()
        {
            // Lógica para agendar una cita
            System.Console.WriteLine("Cita agendada.");
        }

        public void Cancelar()
        {
            // Lógica para cancelar la cita
            System.Console.WriteLine("Cita cancelada.");
        }
    }
}

using PetCare.API.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace PetCare.Models
{
    public class Mascota
    {
        [Key]
        public int IdMascota { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Especie { get; set; }

        [Required]
        public string Raza { get; set; }

        public int Edad { get; set; }

        // Relación: cada mascota pertenece a un cliente.
        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        [JsonIgnore]
        public Cliente Cliente { get; set; }

        // Métodos de negocio
        public void Registrar()
        {
            // Lógica para registrar una nueva mascota
            System.Console.WriteLine("Mascota registrada.");
        }

        public void Actualizar()
        {
            // Lógica para actualizar la información de la mascota
            System.Console.WriteLine("Mascota actualizada.");
        }

        public void Eliminar()
        {
            // Lógica para eliminar una mascota
            System.Console.WriteLine("Mascota eliminada.");
        }
    }
}

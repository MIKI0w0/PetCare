using PetCare.API.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace PetCare.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Telefono { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        // Un cliente puede tener muchas mascotas.
        [JsonIgnore]
        public List<Mascota> Mascotas { get; set; } = new List<Mascota>();

        // Métodos de negocio
        public void Registrar()
        {
            // Lógica para registrar un nuevo cliente
            System.Console.WriteLine("Cliente registrado.");
        }

        public void Actualizar()
        {
            // Lógica para actualizar la información del cliente
            System.Console.WriteLine("Cliente actualizado.");
        }

        public void Eliminar()
        {
            // Lógica para eliminar el cliente
            System.Console.WriteLine("Cliente eliminado.");
        }
    }
}

using PetCare.API.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace PetCare.Models
{
    public class Proveedor
    {
        [Key]
        public int IdProveedor { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Telefono { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        // Un proveedor puede tener varios productos.
        [JsonIgnore]
        public List<Producto> Productos { get; set; } = new List<Producto>();

        // Métodos de negocio
        public void Registrar()
        {
            // Lógica para registrar un nuevo proveedor
            System.Console.WriteLine("Proveedor registrado.");
        }

        public void Actualizar()
        {
            // Lógica para actualizar la información del proveedor
            System.Console.WriteLine("Proveedor actualizado.");
        }

        public void Eliminar()
        {
            // Lógica para eliminar el proveedor
            System.Console.WriteLine("Proveedor eliminado.");
        }
    }
}

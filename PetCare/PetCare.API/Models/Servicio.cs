using PetCare.API.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace PetCare.Models
{
    public class Servicio
    {
        [Key]
        public int IdServicio { get; set; }

        [Required]
        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        // Métodos de negocio
        public void Crear()
        {
            // Lógica para crear un servicio
            System.Console.WriteLine("Servicio creado.");
        }

        public void Modificar()
        {
            // Lógica para modificar un servicio existente
            System.Console.WriteLine("Servicio modificado.");
        }

        public void Eliminar()
        {
            // Lógica para eliminar un servicio
            System.Console.WriteLine("Servicio eliminado.");
        }
    }
}

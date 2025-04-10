using PetCare.API.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace PetCare.Models
{
    public class CitaProducto
    {
        // Nota: Para claves compuestas, la configuración se recomienda hacerla en el DbContext.
        [Key, Column(Order = 0)]
        [ForeignKey("Cita")]
        public int IdCita { get; set; }
        public Cita Cita { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("Producto")]
        public int IdProducto { get; set; }
        public Producto Producto { get; set; }

        public int Cantidad { get; set; }

        // Métodos de negocio
        public void Agregar()
        {
            // Lógica para agregar un producto a la cita
            System.Console.WriteLine("Producto agregado a la cita.");
        }

        public void Remover()
        {
            // Lógica para remover un producto de la cita
            System.Console.WriteLine("Producto removido de la cita.");
        }
    }
}

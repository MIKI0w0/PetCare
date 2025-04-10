using PetCare.API.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace PetCare.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }

        [Required]
        public string Nombre { get; set; }

        public decimal Precio { get; set; }
        public int Stock { get; set; }

        // Relación: cada producto tiene un proveedor.
        [ForeignKey("Proveedor")]
        public int IdProveedor { get; set; }
        public Proveedor Proveedor { get; set; }

        // Métodos de negocio
        public void Registrar()
        {
            // Lógica para registrar un nuevo producto
            System.Console.WriteLine("Producto registrado.");
        }

        public void Modificar()
        {
            // Lógica para modificar el producto
            System.Console.WriteLine("Producto modificado.");
        }

        public void Eliminar()
        {
            // Lógica para eliminar el producto
            System.Console.WriteLine("Producto eliminado.");
        }
    }
}

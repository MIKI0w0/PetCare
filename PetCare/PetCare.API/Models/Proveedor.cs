namespace PetCare.API.Models
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public List<Producto> Productos { get; set; } = new List<Producto>();
    }
}

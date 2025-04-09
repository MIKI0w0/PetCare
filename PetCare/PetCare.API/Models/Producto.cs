namespace PetCare.API.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public int IdProveedor { get; set; }
        public Proveedor Proveedor { get; set; } = null!;

        public List<CitaProducto> CitasProducto { get; set; } = new List<CitaProducto>();
    }
}

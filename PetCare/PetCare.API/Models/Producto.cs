using PetCare.API.Models;

public class Producto
{
    public int IdProducto { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }

    public int IdProveedor { get; set; }
    public Proveedor Proveedor { get; set; }

    public ICollection<CitaProducto> CitasProducto { get; set; }
}

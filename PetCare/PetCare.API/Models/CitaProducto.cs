public class CitaProducto
{
    public int IdCita { get; set; }
    public Cita Cita { get; set; }

    public int IdProducto { get; set; }
    public Producto Producto { get; set; }

    public int Cantidad { get; set; }
}

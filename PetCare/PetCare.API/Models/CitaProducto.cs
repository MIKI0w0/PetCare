namespace PetCare.API.Models
{
    public class CitaProducto
    {
        public int IdCita { get; set; }
        public Cita Cita { get; set; } = null!;

        public int IdProducto { get; set; }
        public Producto Producto { get; set; } = null!;

        public int Cantidad { get; set; }
    }
}

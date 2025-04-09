namespace PetCare.API.Models
{
    public class Cita
    {
        public int IdCita { get; set; }
        public DateTime FechaHora { get; set; }

        public int IdMascota { get; set; }
        public Mascota Mascota { get; set; } = null!;

        public int IdServicio { get; set; }
        public Servicio Servicio { get; set; } = null!;

        public List<CitaProducto> ProductosUtilizados { get; set; } = new List<CitaProducto>();
    }
}

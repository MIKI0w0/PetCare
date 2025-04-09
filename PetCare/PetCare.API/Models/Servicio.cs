namespace PetCare.API.Models
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }

        public List<Cita> Citas { get; set; } = new List<Cita>();
    }
}

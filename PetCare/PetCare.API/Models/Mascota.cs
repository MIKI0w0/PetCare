namespace PetCare.API.Models
{
    public class Mascota
    {
        public int IdMascota { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Especie { get; set; } = string.Empty;
        public string Raza { get; set; } = string.Empty;
        public int Edad { get; set; }

        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; } = null!;
    }
}

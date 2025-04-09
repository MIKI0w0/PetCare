namespace PetCare.API.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public List<Mascota> Mascotas { get; set; } = new List<Mascota>();
    }
}

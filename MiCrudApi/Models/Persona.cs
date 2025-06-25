using System.ComponentModel.DataAnnotations;

namespace MiCrudApi.Models
{
    public class Persona
    {
        public int Id { get; set; }
         [Required]
        public string Nombre { get; set; } = "";

        [Required]
        public string Identificacion { get; set; } = "";

        public List<Mascota> Mascotas { get; set; } = new();     
    }
}
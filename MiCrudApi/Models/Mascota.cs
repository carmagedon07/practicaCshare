using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.Net.Http.Headers;
using MiCrudApi.Models;

namespace MiCrudApi
{
    public class Mascota
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = "";

        public string Tipo { get; set; } = "";

        public int PersonaId { get; set; }

        [JsonIgnore]
        public Persona? Persona { get; set; }
        
    }

 }
using Microsoft.AspNetCore.Mvc;
using MiCrudApi.Models;
using MiCrudApi.Service;

namespace MiCrudApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaService _personaService;

        public PersonaController(IPersonaService personaService)
        {
            _personaService = personaService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var personas = await _personaService.ObtenerTodas();
            return Ok(personas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var persona = await _personaService.ObtenerPorId(id);
            if (persona == null) return NotFound("");
            return Ok(persona);
        }

        [HttpPost]
        public async Task<IActionResult> post(Persona persona)
        {
            await _personaService.Crear(persona);
            return Ok();

        }

        [HttpPut]
        public async Task<IActionResult> put(Persona persona)
        {
            await _personaService.Actualizar(persona);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            await _personaService.Eliminar(id);
            return Ok();

        }
    }
}
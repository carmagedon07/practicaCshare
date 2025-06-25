using Microsoft.EntityFrameworkCore;
using MiCrudApi.Data;
using MiCrudApi.Models;

namespace MiCrudApi.Service.Impl
{
    public class PersonaServiceImpl : IPersonaService
    {

        private readonly AppDbContext _appDbContext;
        public PersonaServiceImpl(AppDbContext _appDbContext)
        {
            this._appDbContext = _appDbContext;
        }
        public async Task Actualizar(Persona persona)
        {
            _appDbContext.Personas.Update(persona);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task Crear(Persona persona)
        {
            _appDbContext.Personas.Add(persona);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task Eliminar(int id)
        {
            var persona = await _appDbContext.Personas.FindAsync(id);
            if (persona != null)
            {
                _appDbContext.Personas.Remove(persona);
                await _appDbContext.SaveChangesAsync();
            
            }
        }

        public async Task<Persona> ObtenerPorId(int id)
        {
            return await _appDbContext.Personas.
            Include(p => p.Mascotas)
            .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Persona>> ObtenerTodas()
        {
            return await _appDbContext.Personas.Include(p=>p.Mascotas).ToListAsync();
        }
    }
}
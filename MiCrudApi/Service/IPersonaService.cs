using MiCrudApi.Models;

namespace MiCrudApi.Service
{
    public interface IPersonaService
    {
        Task<List<Persona>> ObtenerTodas();
        Task<Persona> ObtenerPorId(int id);
        Task Crear(Persona persona);
        Task Actualizar(Persona persona);
        Task Eliminar(int id);
    }

}
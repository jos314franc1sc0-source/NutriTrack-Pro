using NutriTrack.Domain.Entities;

namespace NutriTrack.Infrastructure.Interfaces
{
    public interface IPacienteRepository
    {
        Task<IEnumerable<Paciente>> GetAll();
        Task<Paciente> GetById(int id);
        Task Add(Paciente paciente);
        Task Update(Paciente paciente);
        Task Delete(int id);
    }
}

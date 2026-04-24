using Microsoft.EntityFrameworkCore;
using NutriTrack.Domain.Entities;
using NutriTrack.Infrastructure.Context;
using NutriTrack.Infrastructure.Interfaces;

namespace NutriTrack.Infrastructure.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly NutricionContext _context;

        public PacienteRepository(NutricionContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Paciente>> GetAll()
        {
            return await _context.Pacientes.ToListAsync();
        }

        public async Task<Paciente> GetById(int id)
        {
            return await _context.Pacientes.FindAsync(id);
        }

        public async Task Add(Paciente paciente)
        {
            _context.Pacientes.Add(paciente);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Paciente paciente)
        {
            _context.Pacientes.Update(paciente);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var paciente = await _context.Pacientes.FindAsync(id);
            if (paciente != null)
            {
                _context.Pacientes.Remove(paciente);
                await _context.SaveChangesAsync();
            }
        }
    }
}

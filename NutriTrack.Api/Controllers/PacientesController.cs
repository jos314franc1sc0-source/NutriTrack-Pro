using Microsoft.AspNetCore.Mvc;
using NutriTrack.Domain.Entities;
using NutriTrack.Infrastructure.Interfaces;

namespace NutriTrack.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacientesController : ControllerBase
    {
        private readonly IPacienteRepository _repo;

        public PacientesController(IPacienteRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IEnumerable<Paciente>> Get()
        {
            return await _repo.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Paciente> Get(int id)
        {
            return await _repo.GetById(id);
        }

        [HttpPost]
        public async Task Post(Paciente paciente)
        {
            await _repo.Add(paciente);
        }

        [HttpPut]
        public async Task Put(Paciente paciente)
        {
            await _repo.Update(paciente);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _repo.Delete(id);
        }
    }
}

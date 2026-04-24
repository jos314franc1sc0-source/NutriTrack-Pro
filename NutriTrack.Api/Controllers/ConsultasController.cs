using Microsoft.AspNetCore.Mvc;
using NutriTrack.Infrastructure.Context;
using NutriTrack.Domain.Entities;

namespace NutriTrack.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConsultasController : ControllerBase
    {
        private readonly NutricionContext _context;

        public ConsultasController(NutricionContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Consultas.ToList());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Consulta consulta)
        {
            _context.Consultas.Add(consulta);
            _context.SaveChanges();
            return Ok(consulta);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var consulta = _context.Consultas.Find(id);

            if (consulta == null)
                return NotFound();

            _context.Consultas.Remove(consulta);
            _context.SaveChanges();

            return Ok();
        }
    }
}
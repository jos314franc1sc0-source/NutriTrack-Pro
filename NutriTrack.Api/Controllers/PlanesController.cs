using Microsoft.AspNetCore.Mvc;
using NutriTrack.Infrastructure.Context;
using NutriTrack.Domain.Entities;

namespace NutriTrack.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlanesController : ControllerBase
    {
        private readonly NutricionContext _context;

        public PlanesController(NutricionContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Planes.ToList());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Plan plan)
        {
            _context.Planes.Add(plan);
            _context.SaveChanges();
            return Ok(plan);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var plan = _context.Planes.Find(id);

            if (plan == null)
                return NotFound();

            _context.Planes.Remove(plan);
            _context.SaveChanges();

            return Ok();
        }
    }
}

using NutriTrack.Domain.Core;

namespace NutriTrack.Domain.Entities
{
    public class Nutricionista : BaseEntity
    {
        public required string Nombre { get; set; }
        public required string Correo { get; set; }
    }
}

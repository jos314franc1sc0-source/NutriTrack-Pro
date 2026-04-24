using NutriTrack.Domain.Core;

namespace NutriTrack.Domain.Entities
{
    public class Plan : BaseEntity
    {
        public int PacienteId { get; set; }

        public required string Objetivo { get; set; }
        public int CaloriasObjetivo { get; set; }
    }
}

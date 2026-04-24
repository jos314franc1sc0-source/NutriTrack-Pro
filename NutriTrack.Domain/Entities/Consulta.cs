using NutriTrack.Domain.Core;

namespace NutriTrack.Domain.Entities
{
    public class Consulta : BaseEntity
    {
        public int PacienteId { get; set; }
        public int NutricionistaId { get; set; }

        public DateTime Fecha { get; set; }

        public double Peso { get; set; }
        public double Altura { get; set; }

        public required string Observaciones { get; set; }
    }
}

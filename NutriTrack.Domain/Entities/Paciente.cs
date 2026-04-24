using NutriTrack.Domain.Core;

namespace NutriTrack.Domain.Entities
{
    public class Paciente : BaseEntity
    {
        public required string Nombre { get; set; }
        public required string Cedula { get; set; }
        public int Edad { get; set; }
        public required string Correo { get; set; }

        public double Peso { get; set; }
        public double Altura { get; set; }

        public int Pasos { get; set; }
    }

}

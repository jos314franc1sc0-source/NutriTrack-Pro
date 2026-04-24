using Microsoft.EntityFrameworkCore;
using NutriTrack.Domain.Entities;
using System.Collections.Generic;

namespace NutriTrack.Infrastructure.Context
{
    public class NutricionContext : DbContext
    {
        public NutricionContext(DbContextOptions<NutricionContext> options)
            : base(options)
        {
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Nutricionista> Nutricionistas { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Plan> Planes { get; set; }
    }
}


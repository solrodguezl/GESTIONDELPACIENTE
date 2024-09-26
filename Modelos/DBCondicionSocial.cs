using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Modelos
    {
        public class DBCondicionSocial : DbContext
        {
            public DbSet<Paciente> Pacientes { get; set; }
            public DbSet<Enfermedad> Enfermedades { get; set; }
            public DbSet<Familiar> Familiares { get; set; }
            public DbSet<Cuidador> Cuidadores { get; set; }
            public DbSet<EnfermedadCuidador> EnfermedadesCuidador { get; set; }
            public DbSet<Usuario> Usuarios { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder builder)
            {
                builder.UseSqlServer(ConfigurationManager.ConnectionStrings["CondicionSocial"].ConnectionString);
            }

            protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);

                // Relaciones Paciente - Enfermedad
                builder.Entity<Paciente>()
                    .HasMany(e => e.Enfermedades)
                    .WithOne(e => e.Paciente)
                    .HasForeignKey(e => e.PacienteId);

                // Relaciones Paciente - Familiar
                builder.Entity<Paciente>()
                    .HasMany(e => e.Familiares)
                    .WithOne(e => e.Paciente)
                    .HasForeignKey(e => e.PacienteId);

                // Relaciones Paciente - Cuidador
                builder.Entity<Paciente>()
                    .HasMany(e => e.Cuidadores)
                    .WithOne(e => e.Paciente)
                    .HasForeignKey(e => e.PacienteId);

                // Relaciones Cuidador - EnfermedadCuidador
                builder.Entity<Cuidador>()
                    .HasMany(e => e.EnfermedadesCuidador)
                    .WithOne(e => e.Cuidador)
                    .HasForeignKey(e => e.CuidadorId);
            }
        }
    }
}

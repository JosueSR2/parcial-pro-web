using Microsoft.EntityFrameworkCore;

namespace parcial_1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Define las tablas aquí
        public DbSet<Estudiante> EstudiantesTarde { get; set; }
    }

    // Clase del modelo de Estudiante
    public class Estudiante
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Matricula { get; set; }
        public string Curso { get; set; }
        public string Motivo { get; set; }
        public DateTime Fecha { get; set; } 
    }

}



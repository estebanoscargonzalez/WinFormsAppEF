using Microsoft.EntityFrameworkCore;

namespace WinFormsAppEF;

public class SchoolContext : DbContext
{

    public DbSet<Alumno> Alumnos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conexion = @"Server=localhost\SQLEXPRESS;Database=SchoolDBEF;Trusted_Connection=True;TrustServerCertificate=True;";
        optionsBuilder.UseSqlServer(conexion);
    }
}
using Backend.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Backend.Contexto
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Empleado> Empleados { get; set;}
    }
}

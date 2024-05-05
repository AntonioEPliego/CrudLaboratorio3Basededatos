using Equipodetrabajolabo3.Models;
using Microsoft.EntityFrameworkCore;

namespace Equipodetrabajolabo3.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {
      
        }

        public DbSet<Equipo> equipos { get; set; }
    }
}

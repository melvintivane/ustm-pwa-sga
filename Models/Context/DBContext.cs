using Microsoft.EntityFrameworkCore;

namespace pwa_trabalho_sga.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Estudante> Estudantes { get; set; }
        // public DbSet<Professor> Professores { get; set; }
    }
}
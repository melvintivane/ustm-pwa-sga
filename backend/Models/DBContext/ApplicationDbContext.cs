using Microsoft.EntityFrameworkCore;

namespace pwa_trabalho_sga.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Estudante> Estudantes { get; set; }
        public DbSet<Exame> Exames { get; set; }
        public DbSet<Inscricao> Inscricoes { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<Turma_Disciplina> Turma_Disciplinas { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        // public DbSet<Professor> Professores { get; set; }
        // public DbSet<Admin> Admins { get; set; }
    }
}
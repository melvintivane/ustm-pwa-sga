namespace pwa_trabalho_sga.Models;

public interface INotaRepository
{
    Task<Nota?> AddNotas(Guid estudante, Guid disciplina, Nota notas);
    Task<Nota?> UpdateNotas(Guid estudante, Guid disciplina, Nota notas);
    Task<List<Nota>?> GetNotas();
}
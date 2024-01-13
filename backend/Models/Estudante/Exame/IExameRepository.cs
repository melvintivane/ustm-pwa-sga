namespace pwa_trabalho_sga.Models;

public interface IExameRepository {
    Task<Exame?> AddNotasExames(Guid estudante, Guid disciplina, Exame exame);
    Task<Exame?> UpdateNotasExames(Guid estudante, Guid disciplina, Exame exame);
    Task<List<Exame>?> GetNotasExames();
}
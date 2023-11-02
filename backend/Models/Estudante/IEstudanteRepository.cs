namespace pwa_trabalho_sga.Models;
public interface IEstudanteRepository
{
    Task<Estudante?> Save(Estudante estudante);
    Task<Estudante?> Update(Guid id, Estudante estudante);
    Task<List<Estudante>?> GetAll();
    Task<Estudante?> GetOne(Guid id);
    Task<bool> Delete(Guid id);
} 
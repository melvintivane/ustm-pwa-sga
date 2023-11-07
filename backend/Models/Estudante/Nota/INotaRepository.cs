

namespace pwa_trabalho_sga.Models;

public interface INotaRepository
{
    Task<List<Nota>?> GetNotas();
}
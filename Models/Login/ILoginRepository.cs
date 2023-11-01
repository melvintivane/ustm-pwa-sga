namespace pwa_trabalho_sga.Models;

public interface ILoginRepository
{
    Task<string?> Login(Estudante estudante);
}
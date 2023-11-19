using Microsoft.AspNetCore.Mvc;
using pwa_trabalho_sga.Models;

namespace pwa_trabalho_sga.Controllers;

[ApiController]
public class EstudanteController : ControllerBase
{
    private readonly INotaRepository _notaRepository;

    public EstudanteController(INotaRepository notaRepository)
    {
        _notaRepository = notaRepository;
    }

    [HttpGet("notas/{estudante}/{disciplina}")]
    public async Task<IActionResult> GetNotas(Guid estudante, Guid disciplina)
    {
        var notas = await _notaRepository.GetNotasPorId(estudante, disciplina);

        return Ok(notas);
    }
}
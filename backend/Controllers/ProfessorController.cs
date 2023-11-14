using Microsoft.AspNetCore.Mvc;
using pwa_trabalho_sga.Models;

namespace pwa_trabalho_sga.Controllers;

[ApiController]
public class ProfessorController : ControllerBase
{
    private readonly INotaRepository _notaRepository;

    public ProfessorController(INotaRepository notaRepository)
    {
        _notaRepository = notaRepository;
    }

    [HttpPost("notas/add/{estudante}/{disciplina}")]
    public async Task<IActionResult> AddNotas(Guid estudante, Guid disciplina, [FromBody] Nota notas)
    {
        var novasNotas = await _notaRepository.AddNotas(estudante, disciplina, notas);

        return Ok(novasNotas);
    }

    [HttpPut("notas/update/{estudante}/{disciplina}")]
    public async Task<IActionResult> UpdateNotas(Guid estudante, Guid disciplina, Nota notas)
    {
        var novasNotas = await _notaRepository.UpdateNotas(estudante, disciplina, notas);

        return Ok(novasNotas);
    }
}
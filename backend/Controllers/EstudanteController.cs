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

    [HttpGet("notas")]
    public async Task<IActionResult> GetAll()
    {
        var notas = await _notaRepository.GetNotas();

        return Ok(notas);
    }
}
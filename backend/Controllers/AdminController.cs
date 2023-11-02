using Microsoft.AspNetCore.Mvc;
using pwa_trabalho_sga.Models;

namespace pwa_trabalho_sga.Controllers;

[ApiController]
public class AdminController : ControllerBase
{
    private readonly IEstudanteRepository _estudanteRepository;

    public AdminController(IEstudanteRepository estudanteRepository)
    {
        _estudanteRepository = estudanteRepository;
    }

    //CRIAR ESTUDANTE
    [HttpPost("create")]
    public async Task<IActionResult> Create([FromBody] Estudante estudante)
    {
        var item = await _estudanteRepository.Save(estudante);
        return Ok(item);
    }

    [HttpPut("update/{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] Estudante estudante)
    {
        var item = await _estudanteRepository.Update(id, estudante);
        
        return Ok(item);
    }

    [HttpGet("estudantes")]
    public async Task<IActionResult> GetAll()
    {
        var estudantes = await _estudanteRepository.GetAll();

        return Ok(estudantes);
    }

    [HttpGet("estudante/{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var estudante = await _estudanteRepository.GetOne(id);

        return Ok(estudante);
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var estudante = await _estudanteRepository.Delete(id);

        return Ok(estudante);
    }
}

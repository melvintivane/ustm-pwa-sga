using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using pwa_trabalho_sga.Models;
using Microsoft.AspNetCore.Cors;

namespace pwa_trabalho_sga.Controllers;

[Route("api")]
[ApiController]
public class LoginController : Controller
{
    private readonly ILogger<LoginController> _logger;
    private readonly ILoginRepository _loginRepository;


    public LoginController(ILogger<LoginController> logger, ILoginRepository loginRepository)
    {
        _logger = logger;
        _loginRepository = loginRepository;
    }

    [HttpGet("/")]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(Estudante request)
    {
        var item = await _loginRepository.Login(request);

        return Ok(item);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

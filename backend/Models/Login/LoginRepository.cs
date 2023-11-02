
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace pwa_trabalho_sga.Models;

public class LoginRepository : ILoginRepository
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IConfiguration _configuration;

    public LoginRepository(ApplicationDbContext dbContext, IConfiguration configuration)
    {
        _dbContext = dbContext;
        _configuration = configuration;
    }

    public async Task<string?> Login(Estudante _estudante)
    {
        var estudante = await _dbContext.Estudantes.FirstOrDefaultAsync(x => x.NrEstudante == _estudante.NrEstudante);
        string token = "";

        if (estudante != null)
        {
            if (estudante.NrEstudante != _estudante.NrEstudante)
            {
                return "Wrong Password or Username.";
            }
            if (!BCrypt.Net.BCrypt.Verify(_estudante.Password, estudante.Password))
            {
                return "Wrong Password or Username.";
            }

        token = CreateToken(estudante);
        return token;
        }

        return "Not Found";
    }

    private string CreateToken(Estudante estudante) //precisamos do estudante para gerar os claims
    {
        try
        {
            List<Claim> claims = new()
                {
                    new(ClaimTypes.Name, estudante.Nome!)
                };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value!));

            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials
            );

            var JWT = new JwtSecurityTokenHandler().WriteToken(token);

            return JWT;
        }
        catch (System.Exception)
        {
            throw;
        }
    }
}
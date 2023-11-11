using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace pwa_trabalho_sga.Models;
public class EstudanteRepository : IEstudanteRepository
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IMapper _mapper;

    public EstudanteRepository(ApplicationDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<Estudante?> Save(Estudante _estudante)
    {
        var novoEstudante = await _dbContext.Estudantes.FirstOrDefaultAsync(x => x.Id == _estudante.Id);

        if (novoEstudante == null)
        {
            novoEstudante = new Estudante
            {
                Role = UserRole.Estudante.ToString(),
                NrEstudante = _estudante.NrEstudante,
                Password = BCrypt.Net.BCrypt.HashPassword(_estudante.Password),
                Nome = _estudante.Nome,
                NumeroBI = _estudante.NumeroBI
            };

            await _dbContext.Estudantes.AddAsync(novoEstudante);
            await _dbContext.SaveChangesAsync();

            return novoEstudante;
        }

        return null;
    }
    

    public async Task<Estudante?> Update(Guid id, Estudante _estudante)
    {
        var estudante = await GetOne(id);
        if (estudante != null)
        {
            if (_estudante.Nome != null)
            {
                estudante.Nome = _estudante.Nome;
            }

            if (_estudante.NumeroBI != null)
            {
                estudante.NumeroBI = _estudante.NumeroBI;
            }
        
            await _dbContext.SaveChangesAsync();

            return estudante;
        }

        return null;
    }

    public async Task<Estudante?> GetOne(Guid id)
    {
        var estudante = await _dbContext.Estudantes.FindAsync(id);
        if (estudante != null)
        {
            return estudante;
        }

        return null;
    }

    public async Task<List<Estudante>?> GetAll()
    {
        List<Estudante> values = await _dbContext.Estudantes.ToListAsync();

        if (values != null)
        {
            return _mapper.Map<List<Estudante>>(values);
        }

        return null;
    }

    public async Task<bool> Delete(Guid id)
    {
        var estudante = await _dbContext.Estudantes.FindAsync(id);

        if (estudante != null)
        {
            _dbContext.Estudantes.Remove(estudante);
            await _dbContext.SaveChangesAsync();

            return true;
        }
        return false;
    }
}

using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace pwa_trabalho_sga.Models;



public class NotaRepository : INotaRepository 
{

    private readonly ApplicationDbContext _dbContext;
    private readonly IMapper _mapper;

    public NotaRepository(ApplicationDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<List<Nota>?> GetNotas() {
        List<Nota> notas = await _dbContext.Notas.ToListAsync();

        if (notas != null)
        {
            return _mapper.Map<List<Nota>>(notas);
        }

        return null;
    }
}
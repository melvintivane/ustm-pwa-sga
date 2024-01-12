using AutoMapper;
using Microsoft.EntityFrameworkCore;
using pwa_trabalho_sga.Models;

namespace pwa_trabalho_sga;

public class ExameRepository : IExameRepository
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IMapper _mapper;
    public ExameRepository(ApplicationDbContext dbContext, IMapper mapper) {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<Exame?> AddNotasExames(Guid estudante, Guid disciplina, Exame _notasExame) {
        var notasExame = await _dbContext.Exames.FirstOrDefaultAsync(x => x.Id == estudante && x.Id == disciplina);

        double media = 0;
        if (notasExame == null)
        {
            string observacao = (media >= 10) ? "Aprovado" :  "Reprovado";

            notasExame = new Exame 
            {
                Estudante_Id = estudante,
                Disciplina_Id = disciplina,
                Normal = _notasExame.Normal,
            };
        }

       
        if (notasExame != null)
        {
            if (_notasExame.Normal > -1)
            {
                notasExame.Normal = _notasExame.Normal;
                media = (notasExame.NotaFrequencia + notasExame.Normal) / 2;

            } else if(_notasExame.Recorrencia > -1) 
            {
                notasExame.Recorrencia = _notasExame.Recorrencia;
                media = (notasExame.NotaFrequencia + notasExame.Recorrencia) / 2;
            }
            string observacao = (media >= 10) ? "Aprovado" :  "Reprovado";
        }
        await _dbContext.SaveChangesAsync();
        
        return notasExame;
    }

    public async Task<Exame?> UpdateNotasExames(Guid estudante, Guid disciplina, Exame _notasExame) {
        var notasExame = await _dbContext.Exames.FirstOrDefaultAsync(x => x.Id == estudante && x.Id == disciplina);

        double media = 0;
        if (notasExame != null)
        {
            if(_notasExame.Normal > -1)
            {
                notasExame.Normal = _notasExame.Normal;
                media = (notasExame.NotaFrequencia + notasExame.Normal) / 2;

            } else if(_notasExame.Recorrencia > -1) 
            {
                notasExame.Recorrencia = _notasExame.Recorrencia;
                media = (notasExame.NotaFrequencia + notasExame.Recorrencia) / 2;
            }
            string observacao = (media >= 10) ? "Aprovado" :  "Reprovado";
        }
        await _dbContext.SaveChangesAsync();
        
        return notasExame;
    }

    public async Task<List<Exame>?> GetNotasExames() {
        List<Exame> notasExames = await _dbContext.Exames.ToListAsync();

        if (notasExames != null)
        {
            return _mapper.Map<List<Exame>>(notasExames);
        }

        return null;
    }
}
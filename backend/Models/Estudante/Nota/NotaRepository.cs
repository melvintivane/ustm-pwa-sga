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

    public async Task<Nota?> AddNotas(Guid estudante, Guid disciplina, Nota notas)
    {
        var novasNotas = await _dbContext.Notas.FirstOrDefaultAsync(x => x.Id == notas.Id);
        
        if (novasNotas == null) {
            double media = (notas.Teste1 + notas.Teste2 + notas.Trabalho1 + notas.Trabalho2) / 4;
            string observacao = (media >= 14) ? "Dispensado" : (media < 10) ? "Reprovado" : "Aprovado";

            novasNotas = new Nota 
            {
                Estudante_Id = estudante,
                Disciplina_Id = disciplina,
                Teste1 = notas.Teste1,
                Teste2 = notas.Teste2,
                Trabalho1 = notas.Trabalho1,
                Trabalho2 = notas.Trabalho2,
                Media = media,
                Observacao = observacao,
                Created_At = DateTime.UtcNow,
            };
        };

        await _dbContext.Notas.AddAsync(novasNotas);
        await _dbContext.SaveChangesAsync();

        return novasNotas;
    }

    public async Task<Nota?> UpdateNotas(Guid estudante, Guid disciplina, Nota _notas) 
    {
        var notas = await _dbContext.Notas.FirstOrDefaultAsync(x => x.Estudante_Id == estudante && x.Disciplina_Id == disciplina);
        
        if (notas != null)
        {
            int quantidadeAvaliacoes = 4;
            double somaNotas = 0;

            if (_notas.Teste1 != 0)
            {
                // quantidadeAvaliacoes++;
                somaNotas += _notas.Teste1;
                notas.Teste1 = _notas.Teste1;
            } else {
                notas.Teste1 = notas.Teste1;
                somaNotas += notas.Teste1;
            }

            if (_notas.Teste2 != 0)
            {
                // quantidadeAvaliacoes++;
                somaNotas += _notas.Teste2;
                notas.Teste2 = _notas.Teste2;
            } else {
                notas.Teste2 = notas.Teste2;
                somaNotas += notas.Teste2;
            }

            if (_notas.Trabalho1 != 0)
            {
                // quantidadeAvaliacoes++;
                somaNotas += _notas.Trabalho1;
                notas.Trabalho1 = _notas.Trabalho1;
            } else {
                notas.Trabalho1 = notas.Trabalho1;
                somaNotas += notas.Trabalho1;
            }

            if (_notas.Trabalho2 != 0)
            {
                // quantidadeAvaliacoes++;
                somaNotas += _notas.Trabalho2;
                notas.Trabalho2 = _notas.Trabalho2;
            } else {
                notas.Trabalho2 = notas.Trabalho2;
                somaNotas += notas.Trabalho2;
            }
           
            if (quantidadeAvaliacoes > 0)
            {
                notas.Media = somaNotas / quantidadeAvaliacoes;
            }
        }
        await _dbContext.SaveChangesAsync();
        
        return notas;
    }

    public async Task<List<Nota>?> GetNotas() {
        List<Nota> notas = await _dbContext.Notas.ToListAsync();

        if (notas != null)
        {
            return _mapper.Map<List<Nota>>(notas);
        }

        return null;
    }


    public async Task<List<Nota>?> GetNotasPorId(Guid estudante, Guid disciplina) {
        List<Nota> notas = await _dbContext.Notas.Where(x => x.Estudante_Id == estudante && x.Disciplina_Id == disciplina).ToListAsync();

        if (notas != null)
        {
            return _mapper.Map<List<Nota>>(notas);
        }

        return null;
    }
}
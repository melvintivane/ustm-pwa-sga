using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace pwa_trabalho_sga.Models;
public class EstudanteRepository : IEstudanteRepository
{
    private readonly ApplicationDbContext _dbContext;
    // private readonly IMapper _mapper;

    public EstudanteRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        // _mapper = mapper;
    }

    public async Task<Estudante?> Save(Estudante _estudante)
    {
        var novoEstudante = await _dbContext.Estudantes.FirstOrDefaultAsync(x => x.Id == _estudante.Id);

        if (novoEstudante == null)
        {
            novoEstudante.NrEstudante = _estudante.NrEstudante;
            novoEstudante.Nome = _estudante.Nome;
            novoEstudante.Turma = _estudante.Turma;
            novoEstudante.Curso = _estudante.Curso;

            await _dbContext.Estudantes.AddAsync(novoEstudante);
            await _dbContext.SaveChangesAsync();

            return novoEstudante;

        }

        // var novoEstudante = new Estudante
        // {
        //     NrEstudante = _estudante.NrEstudante,
        //     Nome = _estudante.Nome,
        //     Turma = _estudante.Turma,
        //     Curso = _estudante.Curso
        // };

        // await _dbContext.Estudantes.AddAsync(novoEstudante);
        // await _dbContext.SaveChangesAsync();

        return null;
    }

    public async Task<Estudante?> Update(Guid id, Estudante _estudante)
    {
        var estudante = await _dbContext.Estudantes.FirstOrDefaultAsync(x => x.Id == id);
        if (estudante != null)
        {
            estudante.NrEstudante = _estudante.NrEstudante;
            estudante.Nome = _estudante.Nome;
            estudante.Nome = _estudante.Nome;
            estudante.Nome = _estudante.Nome;
        }
        return null;
    }

    public async Task<Estudante?> GetOne(Guid id)
    {
        var estudante = await _dbContext.Estudantes.FirstOrDefaultAsync(x => x.Id == id);
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
            // return _mapper.Map<List<Estudante>>(values);
        }

        return null;
    }


    public async Task<bool> Delete(int NrEstudante)
    {
        return true;
    }
}
using AutoMapper;
using pwa_trabalho_sga.Models;

namespace pwa_trabalho_sga;

public class AutoMapperHandler : Profile
{
    public AutoMapperHandler()
    {
        CreateMap<Estudante, EstudanteDTO>();
        CreateMap<EstudanteDTO, Estudante>();
    }
}
using AutoMapper;
using DadosApi1.Data.Dtos;
using DadosApi1.Models;

namespace DadosApi1.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<Filme, ReadFilmeDto>();
        CreateMap<UpdateFilmeDto, Filme>();
    }
}

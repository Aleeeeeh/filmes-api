using AutoMapper;
using FilmeAPI.Data.Dtos;
using FilmeAPI.Models;
using FilmesApi.Data.Dtos;

namespace FilmeAPI.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<UpdateFilmeDto, Filme>();
            CreateMap<Filme, UpdateFilmeDto>();
            CreateMap<Filme, ReadFilmeDto>();
        }
    }
}

using AutoMapper;
using MovieAPI.Data.DTO;
using MovieAPI.Models;

namespace MovieAPI.Profiles;

public class MovieProfile : Profile
{
    public MovieProfile() 
    {
        CreateMap<CreateMovieDto, Movie>();
    }
}

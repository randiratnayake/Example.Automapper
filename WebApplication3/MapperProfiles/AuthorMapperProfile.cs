using WebApplication3.Domain;
using WebApplication3.Models;
using AutoMapper;

namespace WebApplication3.MapperProfiles
{
    public class AuthorMapperProfile : Profile
    {
        public AuthorMapperProfile()
        {
            CreateMap<AuthorEntity, AuthorApiModel>();
        }
    }
}

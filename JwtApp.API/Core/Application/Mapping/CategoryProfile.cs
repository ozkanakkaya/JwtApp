using AutoMapper;
using JwtApp.API.Core.Application.Dtos;
using JwtApp.API.Core.Domain;

namespace JwtApp.API.Core.Application.Mapping
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryListDto>().ReverseMap();
        }
    }
}

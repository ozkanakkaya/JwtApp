using AutoMapper;
using Onion.JwtApp.Application.Dtos.CategoryDtos;
using Onion.JwtApp.Domain.Entities;

namespace Onion.JwtApp.Application.Mappings
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryListDto>().ReverseMap();
            CreateMap<Category, CreatedCategoryDto>().ReverseMap();
        }
    }
}

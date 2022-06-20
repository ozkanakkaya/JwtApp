using AutoMapper;
using JwtApp.API.Core.Application.Dtos;
using JwtApp.API.Core.Domain;

namespace JwtApp.API.Core.Application.Mapping
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductListDto>().ReverseMap();
        }
    }
}

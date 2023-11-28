using AutoMapper;
using Onion.JwtApp.Application.Dtos.ProductDtos;
using Onion.JwtApp.Application.Features.CQRS.Commands.Products;
using Onion.JwtApp.Domain.Entities;

namespace Onion.JwtApp.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductListDto>().ReverseMap();
            CreateMap<Product, CreatedProductDto>().ReverseMap();
            CreateMap<Product, CreateProductCommandRequest>().ReverseMap();
        }
    }
}

using MediatR;
using Onion.JwtApp.Application.Dtos.ProductDtos;

namespace Onion.JwtApp.Application.Features.CQRS.Commands.Products
{
    public class CreateProductCommandRequest : IRequest<CreatedProductDto>
    {
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}

using MediatR;
using Onion.JwtApp.Application.Dtos.ProductDtos;

namespace Onion.JwtApp.Application.Features.CQRS.Queries.Products
{
    public class GetProductQueryRequest : IRequest<ProductListDto>
    {
        public int Id { get; set; }

        public GetProductQueryRequest(int id)
        {
            Id = id;
        }
    }
}

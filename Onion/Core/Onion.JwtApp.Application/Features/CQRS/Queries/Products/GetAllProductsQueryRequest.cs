using MediatR;
using Onion.JwtApp.Application.Dtos.ProductDtos;

namespace Onion.JwtApp.Application.Features.CQRS.Queries.Products
{
    public class GetAllProductsQueryRequest : IRequest<List<ProductListDto>>
    {
    }
}

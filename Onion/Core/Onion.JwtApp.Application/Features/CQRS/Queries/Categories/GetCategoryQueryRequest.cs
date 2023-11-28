using MediatR;
using Onion.JwtApp.Application.Dtos.CategoryDtos;

namespace Onion.JwtApp.Application.Features.CQRS.Queries.Categories
{
    public class GetCategoryQueryRequest : IRequest<CategoryListDto>
    {
        public int Id { get; set; }

        public GetCategoryQueryRequest(int id)
        {
            Id = id;
        }
    }
}

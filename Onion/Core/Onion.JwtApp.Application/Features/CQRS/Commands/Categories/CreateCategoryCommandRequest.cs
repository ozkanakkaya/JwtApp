using MediatR;
using Onion.JwtApp.Application.Dtos.CategoryDtos;

namespace Onion.JwtApp.Application.Features.CQRS.Commands.Categories
{
    public class CreateCategoryCommandRequest : IRequest<CreatedCategoryDto?>
    {
        public string? Definition { get; set; }
    }
}

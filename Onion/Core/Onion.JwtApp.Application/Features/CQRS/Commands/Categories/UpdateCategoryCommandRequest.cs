using MediatR;

namespace Onion.JwtApp.Application.Features.CQRS.Commands.Categories
{
    public class UpdateCategoryCommandRequest : IRequest
    {
        public int Id { get; set; }
        public string? Definition { get; set; }
    }
}

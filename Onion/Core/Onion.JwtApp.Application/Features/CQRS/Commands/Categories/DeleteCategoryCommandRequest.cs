using MediatR;

namespace Onion.JwtApp.Application.Features.CQRS.Commands.Categories
{
    public class DeleteCategoryCommandRequest : IRequest
    {
        public int Id { get; set; }

        public DeleteCategoryCommandRequest(int id)
        {
            Id = id;
        }
    }
}

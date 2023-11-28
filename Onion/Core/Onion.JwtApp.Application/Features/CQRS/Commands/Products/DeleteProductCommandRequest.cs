using MediatR;

namespace Onion.JwtApp.Application.Features.CQRS.Commands.Products
{
    public class DeleteProductCommandRequest : IRequest
    {
        public int Id { get; set; }

        public DeleteProductCommandRequest(int id)
        {
            Id = id;
        }
    }
}

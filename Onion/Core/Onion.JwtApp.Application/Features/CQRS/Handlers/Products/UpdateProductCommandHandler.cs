using MediatR;
using Onion.JwtApp.Application.Features.CQRS.Commands.Products;
using Onion.JwtApp.Application.Interfaces;
using Onion.JwtApp.Domain.Entities;

namespace Onion.JwtApp.Application.Features.CQRS.Handlers.Products
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest>
    {
        private readonly IRepository<Product> _repository;

        public UpdateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var updateProduct = await _repository.GetByIdAsync(request.Id);
            if (updateProduct!=null)
            {
                updateProduct.CategoryId = request.CategoryId;
                updateProduct.Stock = request.Stock;
                updateProduct.Price = request.Price;
                updateProduct.Name = request.Name;
                await _repository.SaveChangesAsync();
            }
            return Unit.Value;
        }
    }
}

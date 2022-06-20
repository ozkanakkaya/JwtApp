using JwtApp.API.Core.Application.Features.CQRS.Commands;
using JwtApp.API.Core.Application.Interfaces;
using JwtApp.API.Core.Domain;
using MediatR;

namespace JwtApp.API.Core.Application.Features.CQRS.Handlers
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
                await _repository.UpdateAsync(updateProduct);
            }
            return Unit.Value;
        }
    }
}

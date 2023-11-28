using MediatR;
using Onion.JwtApp.Application.Features.CQRS.Commands.Categories;
using Onion.JwtApp.Application.Interfaces;
using Onion.JwtApp.Domain.Entities;

namespace Onion.JwtApp.Application.Features.CQRS.Handlers.Categories
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommandRequest>
    {
        private readonly IRepository<Category> _repository;

        public UpdateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            //CONNECTED
            var updateCategory = await _repository.GetByIdAsync(request.Id);
            if (updateCategory != null)
            {
                updateCategory.Definition = request.Definition;
                await _repository.SaveChangesAsync();
            }
            return Unit.Value;

            //DISCONNECTED
            //var updatedCategory = new Category()
            //{
            //    Definition = request.Definition,
            //    Id = request.Id
            //};
            //await _repository.UpdateAsync(updatedCategory);//entry modified olarak işaretlendi
            //return Unit.Value;
        }
    }
}


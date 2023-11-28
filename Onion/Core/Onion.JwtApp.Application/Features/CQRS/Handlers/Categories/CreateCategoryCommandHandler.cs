using AutoMapper;
using MediatR;
using Onion.JwtApp.Application.Dtos.CategoryDtos;
using Onion.JwtApp.Application.Features.CQRS.Commands.Categories;
using Onion.JwtApp.Application.Interfaces;
using Onion.JwtApp.Domain.Entities;

namespace Onion.JwtApp.Application.Features.CQRS.Handlers.Categories
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest, CreatedCategoryDto?>
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CreatedCategoryDto?> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var result = await _repository.CreateAsync(new Category
            {
                Definition = request.Definition
            });

            return _mapper.Map<CreatedCategoryDto>(result);
        }
    }
}

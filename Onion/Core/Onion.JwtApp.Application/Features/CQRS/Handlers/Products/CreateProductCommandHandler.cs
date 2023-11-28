using AutoMapper;
using MediatR;
using Onion.JwtApp.Application.Dtos.ProductDtos;
using Onion.JwtApp.Application.Features.CQRS.Commands.Products;
using Onion.JwtApp.Application.Interfaces;
using Onion.JwtApp.Domain.Entities;

namespace Onion.JwtApp.Application.Features.CQRS.Handlers.Products
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreatedProductDto?>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CreatedProductDto?> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            //new Product// aşağıda bu işlemi mapper yapıyor.
            //{
            //    CategoryId = request.CategoryId,
            //    Name = request.Name,
            //    Price = request.Price,
            //    Stock = request.Stock
            //}
            var result = await _repository.CreateAsync(_mapper.Map<Product>(request));
            return _mapper.Map<CreatedProductDto>(result);
        }
    }
}

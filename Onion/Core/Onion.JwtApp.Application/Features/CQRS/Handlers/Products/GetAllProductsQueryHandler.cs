using AutoMapper;
using MediatR;
using Onion.JwtApp.Application.Dtos.ProductDtos;
using Onion.JwtApp.Application.Features.CQRS.Queries.Products;
using Onion.JwtApp.Application.Interfaces;
using Onion.JwtApp.Domain.Entities;

namespace Onion.JwtApp.Application.Features.CQRS.Handlers.Products
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, List<ProductListDto>>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;

        public GetAllProductsQueryHandler(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ProductListDto>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await _repository.GetAllAsync();
            return _mapper.Map<List<ProductListDto>>(products);
        }
    }
}

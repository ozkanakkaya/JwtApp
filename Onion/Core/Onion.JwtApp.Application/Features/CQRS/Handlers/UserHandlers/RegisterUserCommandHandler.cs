using AutoMapper;
using MediatR;
using Onion.JwtApp.Application.Dtos.UserDtos;
using Onion.JwtApp.Application.Enums;
using Onion.JwtApp.Application.Features.CQRS.Commands.UserCommands;
using Onion.JwtApp.Application.Interfaces;
using Onion.JwtApp.Domain.Entities;

namespace JwtApp.API.Core.Application.Features.CQRS.Handlers
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommandRequest, CreatedUserDto?>
    {
        private readonly IRepository<AppUser> _repository;
        private readonly IMapper _mapper;

        public RegisterUserCommandHandler(IRepository<AppUser> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CreatedUserDto?> Handle(RegisterUserCommandRequest request, CancellationToken cancellationToken)
        {
            var data = await _repository.CreateAsync(new AppUser
            {
                AppRoleId = (int)RoleType.Member,
                Password = request.Password,
                Username = request.Username,
            });
            return _mapper.Map<CreatedUserDto>(data);
        }
    }
}

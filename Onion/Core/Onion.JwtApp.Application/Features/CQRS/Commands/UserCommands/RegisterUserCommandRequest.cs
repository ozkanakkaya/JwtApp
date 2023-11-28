using MediatR;
using Onion.JwtApp.Application.Dtos.UserDtos;

namespace Onion.JwtApp.Application.Features.CQRS.Commands.UserCommands
{
    public class RegisterUserCommandRequest : IRequest<CreatedUserDto?>
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}

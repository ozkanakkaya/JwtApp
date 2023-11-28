using MediatR;
using Onion.JwtApp.Application.Dtos.UserDtos;

namespace JwtApp.API.Core.Application.Features.CQRS.Queries
{
    public class CheckUserQueryRequest : IRequest<CheckUserResponseDto>
    {
        public string Username { get; set; } = null!;

        public string Password { get; set; } = null!;
    }
}

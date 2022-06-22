﻿using JwtApp.API.Core.Application.Features.CQRS.Commands;
using JwtApp.API.Core.Application.Features.CQRS.Queries;
using JwtApp.API.Infrastructure.Tools;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtApp.API.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Register(RegisterUserCommandRequest request)
        {
            await _mediator.Send(request);
            return Created("", request);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> SignIn(CheckUserQueryRequest request)
        {
            var userDto = await _mediator.Send(request);
            if (userDto.IsExist)
            {
                var token = JwtTokenGenerator.GenerateToken(userDto);
                return Created("", token);
            }
            return BadRequest("Username veya parola hatalıdır.");
        }
    }
}

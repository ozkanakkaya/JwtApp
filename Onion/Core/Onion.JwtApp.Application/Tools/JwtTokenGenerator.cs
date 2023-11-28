using Microsoft.IdentityModel.Tokens;
using Onion.JwtApp.Application.Dtos.TokenDtos;
using Onion.JwtApp.Application.Dtos.UserDtos;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Onion.JwtApp.Application.Tools
{
    public class JwtTokenGenerator
    {
        public static TokenResponseDto GenerateToken(CheckUserResponseDto dto)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenSettings.Key));

            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            List<Claim> claims = new List<Claim>();

            if(!string.IsNullOrWhiteSpace(dto.Role))
                claims.Add(new Claim(ClaimTypes.Role, dto.Role));

            if (!string.IsNullOrWhiteSpace(dto.Username))
                claims.Add(new Claim(ClaimTypes.Name, dto.Username));

            claims.Add(new Claim(ClaimTypes.NameIdentifier, dto.Id.ToString()));

            var expireDate = DateTime.UtcNow.AddDays(JwtTokenSettings.Expire);

            JwtSecurityToken token = new JwtSecurityToken(issuer: JwtTokenSettings.Issuer, audience: JwtTokenSettings.Audience, claims: claims, notBefore: DateTime.UtcNow, expires: expireDate, signingCredentials: credentials);

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            return new TokenResponseDto(handler.WriteToken(token), expireDate);
        }
    }
}

﻿namespace JwtApp.API.Infrastructure.Tools
{
    public class JwtTokenResponse
    {
        public JwtTokenResponse(string token, DateTime expireDate)
        {
            Token = token;
            ExpireDate = expireDate;
        }

        public string Token { get; set; } = string.Empty;

        public DateTime ExpireDate { get; set; }
    }
}

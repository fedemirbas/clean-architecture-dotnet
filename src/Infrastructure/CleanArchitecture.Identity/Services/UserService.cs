using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.Dtos.User;
using CleanArchitecture.Application.Exceptions;
using CleanArchitecture.Application.Interfaces.Services;
using CleanArchitecture.Application.Wrappers;
using CleanArchitecture.Domain.Settings;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace CleanArchitecture.Identity.Services
{
    public class UserService : IUserService
    {
        private readonly JWTSettings _jwtSettings;
        public UserService(IOptions<JWTSettings> jwtSettings)
        {
            _jwtSettings = jwtSettings.Value;
        }

        public async Task<Response<AuthenticationResponse>> AuthenticateAsync(AuthenticationRequest request)
        {
            //Need to check request email/password from UserRepository
            var UserId = Guid.NewGuid().ToString();
            JwtSecurityToken jwtSecurityToken = await GenerateJWToken(UserId, request.Email);
            AuthenticationResponse response = new AuthenticationResponse();
            response.Id = UserId;
            response.JWToken = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            response.Email = request.Email;
            response.UserName = "super";
            response.Roles = new List<string>(){"account-view", "account-action", "customer-view" };
            response.IsVerified = true;
            var refreshToken = GenerateRefreshToken();
            response.RefreshToken = refreshToken.Token;
            return new Response<AuthenticationResponse>(response, $"Authenticated super");
        }

        private async Task<JwtSecurityToken> GenerateJWToken(string userId, string email)
        {
            var roles = new List<string>() { "account-view", "account-action", "customer-view" };

            var roleClaims = new List<Claim>();

            for (int i = 0; i < roles.Count; i++)
            {
                roleClaims.Add(new Claim("roles", roles[i]));
            }
            
            var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, "super"),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Email, email),
                    new Claim("uid", userId),
                    new Claim("ip", "super")
                }
                .Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_jwtSettings.DurationInMinutes),
                signingCredentials: signingCredentials);
            return jwtSecurityToken;
        }

        private RefreshToken GenerateRefreshToken()
        {
            return new RefreshToken
            {
                Token = RandomTokenString(),
                Expires = DateTime.UtcNow.AddDays(7),
                Created = DateTime.UtcNow,
                CreatedByIp = "super"
            };
        }

        private string RandomTokenString()
        {
            using var rngCryptoServiceProvider = new RNGCryptoServiceProvider();
            var randomBytes = new byte[40];
            rngCryptoServiceProvider.GetBytes(randomBytes);
            // convert random bytes to hex string
            return BitConverter.ToString(randomBytes).Replace("-", "");
        }
    }
}

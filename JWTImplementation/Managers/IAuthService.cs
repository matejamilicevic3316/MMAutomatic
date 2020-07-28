using JWTImplementation.Models;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace JWTImplementation.Managers
{
    public interface IAuthService
    {
        string SecretKey { get; set; }
        bool IsTokenValid(string token);
        string GenerateToken(IAuthContainerModel model);
        IEnumerable<Claim> GetTokenClaims(string token);
    }
}

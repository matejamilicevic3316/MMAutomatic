using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace JWTImplementation.Models
{
    public class JwtContainerModel : IAuthContainerModel
    {
        public string SecretKey { get; set; } = "Th9zaGVFcmV6UhJpdmF0ZUtleQ==";
        public string SecurityAlgorithm { get; set; } = SecurityAlgorithms.HmacSha256Signature;
        public int ExpireMinutes { get; set; } = 60;
        public Claim[] Claims { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

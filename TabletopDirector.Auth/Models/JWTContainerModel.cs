using Microsoft.IdentityModel.Tokens;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using TabletopDirector.Auth.Services;

namespace TabletopDirector.Auth.Models
{
    public class JWTContainerModel : IAuthContainerModel
    {
        public string SecretKey { get; set; } = KeysService.GenerateNew();
        public string SecurityAlgorithm { get; set; } = SecurityAlgorithms.HmacSha256Signature;
        public int ExpireMinutes { get; set; } = 10080; // 7 days
        public Claim[] Claims { get; set; }
    }
}

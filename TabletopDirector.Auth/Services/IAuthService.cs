using System.Collections.Generic;
using System.Security.Claims;
using TabletopDirector.Auth.Models;

namespace TabletopDirector.Auth.Services
{
    public interface IAuthService
    {
        string SecretKey { get; set; }
        bool IsTokenValid(string token);
        string GenerateToken(IAuthContainerModel model);
        IEnumerable<Claim> GetTokenClaims(string token);
    }
}
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using TabletopDirector.Auth.Models;
using TabletopDirector.Auth.Services;

namespace TabletopDirector.Tests.Auth
{
    [TestFixture]
    public class AuthTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAuth()
        {
            JWTContainerModel JWT = new JWTContainerModel()
            {
                Claims = new Claim[]
                {
                    new Claim(ClaimTypes.Name, "Kent Utterback"),
                    new Claim(ClaimTypes.Email, "utterback.kent.a@gmail.com")
                }
            };

            JWTService authService = new JWTService(JWT.SecretKey);

            string token = authService.GenerateToken(JWT);

            if (!authService.IsTokenValid(token))
            {
                Assert.Fail();
            }

            List<Claim> claims = authService.GetTokenClaims(token).ToList();
            Assert.Equals(claims.FirstOrDefault(claim => claim.Type.Equals(ClaimTypes.Name)).Value, "Kent Utterback");
            Assert.Equals(claims.FirstOrDefault(claim => claim.Type.Equals(ClaimTypes.Email)).Value, "utterback.kent.a@gmail.com");
        }
    }
}
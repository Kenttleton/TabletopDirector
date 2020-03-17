using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace TabletopDirector.Auth.Services
{
    public class KeysService
    {
        public static string GenerateNew()
        {
            byte[] entropyArr = new byte[16];
            var random = new Random();
            random.NextBytes(entropyArr);
            return new Guid(entropyArr).ToString();
        }
    }
}

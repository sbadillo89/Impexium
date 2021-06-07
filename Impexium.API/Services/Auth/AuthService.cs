using Impexium.API.Models;
using Impexium.API.Utils;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Impexium.API.Services
{
    public class AuthService : IAuthService
    {
        private readonly Impexium_DBContext _context;
        private readonly AppSettings _appSettings;

        public AuthService(Impexium_DBContext context, IOptions<AppSettings> appSettings)
        {
            _context = context;
            _appSettings = appSettings.Value;
        }

        public AuthResponse Auth(AuthRequest authRequest)
        {
            AuthResponse userResponse = new AuthResponse();

            string passwordEncrypt = Encryp.GetSHA256(authRequest.Password);

            var user = _context.Users.
                        Where(u => u.Name == authRequest.User && u.Password == passwordEncrypt) 
                        .FirstOrDefault();

            if (user == null) return null;

            int validezToken = (_appSettings != null ? _appSettings.HorasValidezToken : 1);
            userResponse.Token = GetToken(user, validezToken);
            userResponse.UserName = user.Name;
            userResponse.ExpireDate = DateTime.Now.AddHours(validezToken);
            userResponse.UserId = user.Id;

            return userResponse;
        }

        private string GetToken(User usuario, int tiempoValidez)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var llave = Encoding.ASCII.GetBytes(_appSettings.Secreto);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString() ),
                        new Claim(ClaimTypes.Name, usuario.Name),
                        new Claim(ClaimTypes.Expiration,DateTime.UtcNow.AddHours(tiempoValidez).ToLongDateString() )
                    }
                    ),
                Expires = DateTime.UtcNow.AddHours(tiempoValidez),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(llave), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Impexium.API.Services
{
    public interface IAuthService
    {
       AuthResponse Auth(AuthRequest authRequest);
    }
}

using Impexium.Proxy.Repository;
using System;
using System.Threading.Tasks;

namespace Impexium.Proxy.Services
{
    public class AuthService : IAuthServices
    {
        readonly IRepository<AuthResponse> repository = new Repository<AuthResponse>();
         

        public async Task<GlobalResponse> Login(AuthRequest request)
        {
            return await repository.Login("api/Auth/login", request);
        }
    }
}

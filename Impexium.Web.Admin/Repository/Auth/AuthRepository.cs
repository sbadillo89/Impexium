using Impexium.Proxy;
using Impexium.Proxy.Services;
using System.Threading.Tasks;

namespace Impexium.Web.Admin.Repository
{
    public class AuthRepository : IAuthRepository
    {
        readonly IAuthServices authServices = new AuthService();

        public async Task<AuthResponse> Login(AuthRequest authRequest)
        {

            GlobalResponse response = await authServices.Login(authRequest);

            return Newtonsoft.Json.JsonConvert.DeserializeObject<AuthResponse>(response.ResponseData);

        }
    }
}

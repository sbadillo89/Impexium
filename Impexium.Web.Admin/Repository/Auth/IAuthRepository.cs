using Impexium.Proxy.Services;
using System.Threading.Tasks;

namespace Impexium.Web.Admin.Repository
{
    public interface IAuthRepository
    {
        Task<AuthResponse> Login(AuthRequest authRequest);
    }
}

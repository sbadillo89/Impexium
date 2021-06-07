using System.Threading.Tasks;

namespace Impexium.Proxy.Services
{
    public interface IAuthServices
    {
        Task<GlobalResponse> Login(AuthRequest request);
    }
}

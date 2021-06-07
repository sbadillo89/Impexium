using Impexium.Proxy.Services;
using System.Threading.Tasks;

namespace Impexium.Proxy.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<GlobalResponse> GetAllAsync(string requestUri);

        Task<GlobalResponse> GetByIdAsync(string requestUri);

       Task<GlobalResponse> PostAsync(string requestUri, T requestData, string token);
      
       Task<GlobalResponse> PutAsync(string requestUri, T requestData, string token);

        Task<GlobalResponse> Login(string requestUri, AuthRequest auth);
       

    }
}

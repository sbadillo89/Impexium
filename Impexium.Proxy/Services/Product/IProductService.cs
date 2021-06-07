
using Impexium.Proxy.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Impexium.Proxy.Services
{
    public interface IProductService
    { 
        Task<GlobalResponse> GetAllAsync();
        Task<GlobalResponse> GetByIdAsync(string id);
        Task<GlobalResponse> PostAsync( Product product, string token);
        Task<GlobalResponse> PutAsync( Product product, string id, string token); 
     

    }
}

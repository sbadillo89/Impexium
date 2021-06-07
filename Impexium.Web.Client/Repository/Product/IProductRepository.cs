using Impexium.Proxy;
using Impexium.Proxy.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace web_app.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(string id);
    
    }
}

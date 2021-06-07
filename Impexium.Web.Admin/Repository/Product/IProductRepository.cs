using Impexium.Proxy.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Impexium.Web.Admin.Repository
{
    public interface IProductRepository
    { 
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(string id);
        Task<Product> PostAsync(Product product,string token);
        Task<bool> PutAsync(Product product, string id, string token);
    }
}

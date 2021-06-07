using Impexium.Proxy.Models;
using Impexium.Proxy.Repository;
using System.Threading.Tasks;

namespace Impexium.Proxy.Services
{
    public class ProductService : IProductService
    {
        readonly IRepository<Product> repository = new Repository<Product>();
         
        public async Task<GlobalResponse> GetAllAsync()
        {
            return await repository.GetAllAsync("api/Product");
        }

        public async Task<GlobalResponse> GetByIdAsync(string id)
        {
            return await repository.GetByIdAsync($"api/Product/{id}");
        }
         
        public async Task<GlobalResponse> PostAsync( Product product, string token)
        {
            return await repository.PostAsync("api/Product", product, token);
        }

        public async Task<GlobalResponse> PutAsync( Product product, string id, string token)
        {
            return await repository.PutAsync($"api/Product/{id}", product, token);
        }
    }
}

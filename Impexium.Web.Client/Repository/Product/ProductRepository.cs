using Impexium.Proxy;
using Impexium.Proxy.Models;
using System;
using System.Threading.Tasks;
using Impexium.Proxy.Services;
using System.Collections.Generic;

namespace web_app.Repository
{
    public class ProductRepository : IProductRepository
    {
        readonly IProductService productService = new ProductService(); 

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            GlobalResponse response = await productService.GetAllAsync();
            if (response.Status == System.Net.HttpStatusCode.OK)
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Product>>(response.ResponseData);
            }
            return null;
        }

        public async Task<Product> GetByIdAsync(string id)
        {
            GlobalResponse response = await productService.GetByIdAsync(id);
            if (response.Status == System.Net.HttpStatusCode.OK)
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<Product>(response.ResponseData);
            }
            return null;
        } 
    }
}

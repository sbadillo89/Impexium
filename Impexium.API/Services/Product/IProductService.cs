using Impexium.API.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Impexium.API.Services
{
    public interface IProductService
    {

        Task<IEnumerable<Product>> GetAll();

         Task<Product> GetById(Guid id);

        Task<bool> Update(Product product);

        Task Create(Product newProduct);
         

    }
}

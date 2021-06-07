using Impexium.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Impexium.API.Services
{
    public class ProductService : IProductService
    {
        public readonly Impexium_DBContext _context;

        public ProductService(Impexium_DBContext context)
        {
            _context = context;
        }
        public async Task Create(Product newProduct)
        {
            if (newProduct == null)
                throw new ArgumentNullException(nameof(newProduct));

            _context.Products.Add(newProduct);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetById(Guid id)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<bool> Update(Product product)
        {
            _context.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            int rowsAffected = await _context.SaveChangesAsync();
            return (rowsAffected > 0);
        }

    }
}

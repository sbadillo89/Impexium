using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Impexium.Proxy.Services;

namespace Impexium.Test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await GetAllProductsTets();
            // await PostProductTets();
           // await LoginTets();

        }

        static async Task LoginTets()
        {
            try
            {
                IAuthServices service = new AuthService();
                var response = await service.Login(new Proxy.Services.AuthRequest() { User="sadasd", Password="clave.1234"});

                Console.WriteLine($"Process completed \n  Login response: {response.RequestData} \n {response.ResponseData}");
            }
            catch (Exception)
            {
                Console.WriteLine($"Error saving a product...");
            }
        }

        static async Task GetAllProductsTets()
        {
            try
            {
                IProductService productService = new ProductService(); 

                var response = await productService.GetAllAsync().ConfigureAwait(false);

                Console.WriteLine($"Process completed \n {response.Message}");
            }
            catch (Exception)
            {
                Console.WriteLine($"Error loading products...");
            }
        }

        static async Task PostProductTets()
        {
            try
            {
                IProductService productService = new ProductService();
                var response = await productService.PostAsync(new Proxy.Models.Product() { Name = "product test", Description = "description test", Quantity = 1 }, "token");

                Console.WriteLine($"Process completed \n  Product created: {response.Message}-{response.ResponseData}");
            }
            catch (Exception)
            {
                Console.WriteLine($"Error saving a product...");
            }
        }

    }
}

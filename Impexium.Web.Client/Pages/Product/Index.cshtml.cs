using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace web_app.Pages.Product
{
    public class IndexModel : PageModel
    {
        Repository.IProductRepository repository = new Repository.ProductRepository();
        public IEnumerable<Impexium.Proxy.Models.Product> Products;

        public async Task OnGetAsync()
        {
            Products = await repository.GetAllAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace web_app.Pages.Product
{
    public class DetailsModel : PageModel
    {
        Repository.IProductRepository repository = new Repository.ProductRepository();

        public Impexium.Proxy.Models.Product Product;
        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await repository.GetByIdAsync(id.ToString());

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }

    }
}

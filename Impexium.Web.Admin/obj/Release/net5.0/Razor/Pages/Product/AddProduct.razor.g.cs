#pragma checksum "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\Pages\Product\AddProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69de0347dcaa68b62c8ba79c8fc737d179c017ec"
// <auto-generated/>
#pragma warning disable 1591
namespace Impexium.Web.Admin.Pages.Product
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Impexium.Web.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Impexium.Web.Admin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Impexium.Web.Admin.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Impexium.Proxy.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Impexium.Proxy.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Impexium.Web.Admin.Pages.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Impexium.Web.Admin.Pages.Product;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/add")]
    public partial class AddProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Impexium.Web.Admin.Pages.Product.AddProduct>(0);
            __builder.AddAttribute(1, "ProductToUpdate", 
#nullable restore
#line 7 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\Pages\Product\AddProduct.razor"
                                                               NewProduct

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "Title", "Add Product");
            __builder.AddAttribute(3, "ButtonText", "Save");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\Pages\Product\AddProduct.razor"
       

    [Parameter]
    public Product NewProduct { get; set; }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductRepository productRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsr { get; set; }
    }
}
#pragma warning restore 1591
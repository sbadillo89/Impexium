#pragma checksum "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\Pages\Product\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d023d873c59b222326d0238e82769dd093a2ce8"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/product")]
    public partial class Products : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "justify-content-center align-items-center");
            __builder.AddMarkupContent(4, "<div class=\"my-lg-4\"><h3 class=\"text-danger flex-grow-1 font-weight-bold\">List of Products</h3></div>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table table-hover");
            __builder.AddMarkupContent(8, @"<thead><tr class=""bg-danger text-white""><th scope=""col"">Name</th>
                        <th scope=""col"">Description</th>
                        <th scope=""col"">Price</th>
                        <th scope=""col"">Quantity</th>
                        <th scope=""col"">Created date</th>
                        <th scope=""col""></th></tr></thead>
                ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 25 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\Pages\Product\Products.razor"
                     if (ProductList != null)
                    {
                        foreach (var product in ProductList)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 30 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\Pages\Product\Products.razor"
                                     product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 31 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\Pages\Product\Products.razor"
                                     product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 32 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\Pages\Product\Products.razor"
                                     product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 33 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\Pages\Product\Products.razor"
                                     product.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 34 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\Pages\Product\Products.razor"
                                     product.CreatedDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                                ");
            __builder.OpenElement(26, "td");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "href", "product/edit/" + (
#nullable restore
#line 36 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\Pages\Product\Products.razor"
                                                           product.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "class", "btn btn-warning btn-sm");
            __builder.AddAttribute(30, "role", "button");
            __builder.AddContent(31, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\Pages\Product\Products.razor"
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "<tr><td colspan=\"5\" class=\"font-italic\">No data available yet...</td></tr>");
#nullable restore
#line 46 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\Pages\Product\Products.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n            ");
            __builder.AddMarkupContent(34, "<a href=\"product/add\" class=\"btn btn-danger\" role=\"button\">Add product</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\SBadillo\source\repos\Impexium_Test\Impexium.Web.Admin\Pages\Product\Products.razor"
       

    IEnumerable<Product> ProductList { get; set; }
    string userData = string.Empty;

    protected async override Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        userData = await jsr.InvokeAsync<string>("localStorage.getItem", "token-impexium").ConfigureAwait(false);
        DateTime expireDate = DateTime.MinValue;
        if (!string.IsNullOrEmpty(userData))
        {
            ProductList = await productRepository.GetAllAsync();
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductRepository productRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsr { get; set; }
    }
}
#pragma warning restore 1591

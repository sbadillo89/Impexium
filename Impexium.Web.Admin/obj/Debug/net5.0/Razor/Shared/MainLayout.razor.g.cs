#pragma checksum "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e458df6f18ac0ecb68df25eb213d1e63d73559b"
// <auto-generated/>
#pragma warning disable 1591
namespace Impexium.Web.Admin.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Impexium.Web.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Impexium.Web.Admin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Impexium.Web.Admin.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Impexium.Proxy.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Impexium.Proxy.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Impexium.Web.Admin.Pages.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\_Imports.razor"
using Impexium.Web.Admin.Pages.Product;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\Shared\MainLayout.razor"
 if (IsLogged)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-fdgw7gf5nx");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-fdgw7gf5nx");
            __builder.OpenComponent<Impexium.Web.Admin.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-fdgw7gf5nx");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4 bg-danger");
            __builder.AddAttribute(13, "b-fdgw7gf5nx");
#nullable restore
#line 14 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\Shared\MainLayout.razor"
                 if (!string.IsNullOrEmpty(UserName))
                {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(14);
            __builder.AddAttribute(15, "class", "nav-link text-white border-right border-white");
            __builder.AddAttribute(16, "href", "#");
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(18, "<span class=\"oi oi-person mr-2\" aria-hidden=\"true\" b-fdgw7gf5nx></span> ");
                __builder2.AddMarkupContent(19, "<span b-fdgw7gf5nx>Hi, </span>\r\n                        ");
                __builder2.OpenElement(20, "span");
                __builder2.AddAttribute(21, "class", "text-capitalize");
                __builder2.AddAttribute(22, "b-fdgw7gf5nx");
                __builder2.AddContent(23, 
#nullable restore
#line 18 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\Shared\MainLayout.razor"
                                                       UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(25);
            __builder.AddAttribute(26, "class", "nav-link text-white");
            __builder.AddAttribute(27, "href", "/logout");
            __builder.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(29, "<span class=\"oi oi-account-logout\" aria-hidden=\"true\" b-fdgw7gf5nx></span> Logout\r\n                    ");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 23 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\Shared\MainLayout.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "content px-4");
            __builder.AddAttribute(33, "b-fdgw7gf5nx");
            __builder.AddContent(34, 
#nullable restore
#line 27 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\Shared\MainLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\Shared\MainLayout.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Impexium.Web.Admin.Pages.Auth.Login>(35);
            __builder.CloseComponent();
#nullable restore
#line 35 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\Shared\MainLayout.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\Shared\MainLayout.razor"
       
    string UserName = string.Empty;
    bool IsLogged = false;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        var userdata = await jsr.InvokeAsync<string>("localStorage.getItem", "token-impexium").ConfigureAwait(false);
        DateTime expireDate = DateTime.MinValue;
        if (!string.IsNullOrEmpty(userdata))
        {
            IsLogged = true;
            UserName = userdata.Split(';', 3)[0];
            expireDate = Convert.ToDateTime(userdata.Split(';', 3)[2]);
            if (DateTime.Now > expireDate)
            {
                await jsr.InvokeVoidAsync("localStorage.removeItem", "token-impexium").ConfigureAwait(false);

                IsLogged = false;
                navigationManager.NavigateTo("/", true);
            }

        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsr { get; set; }
    }
}
#pragma warning restore 1591

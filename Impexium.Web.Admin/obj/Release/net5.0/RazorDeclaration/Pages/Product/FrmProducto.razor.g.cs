// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Impexium.Web.Admin.Pages.Product
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
    public partial class FrmProducto : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\SBadillo\Desktop\test\Impexium_Test\Impexium.Web.Admin\Pages\Product\FrmProducto.razor"
       

    [Parameter]
    public Product Product { get; set; }

    [Parameter]
    public bool IsNew { get; set; }

    [Parameter]
    public string ButtonText { get; set; }

    [Parameter]
    public EventCallback OnValidSubmit { get; set; }

    [Parameter]
    public string Title { get; set; }
     
    public FrmProducto()
    { 
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

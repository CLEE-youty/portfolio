#pragma checksum "C:\Users\ysspe\Documents\WorkSpace\portfolio\portfolio\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e1a954088bc3fecb2f0b16c29930789f7184751"
// <auto-generated/>
#pragma warning disable 1591
namespace portfolio.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ysspe\Documents\WorkSpace\portfolio\portfolio\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ysspe\Documents\WorkSpace\portfolio\portfolio\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ysspe\Documents\WorkSpace\portfolio\portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ysspe\Documents\WorkSpace\portfolio\portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ysspe\Documents\WorkSpace\portfolio\portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ysspe\Documents\WorkSpace\portfolio\portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ysspe\Documents\WorkSpace\portfolio\portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ysspe\Documents\WorkSpace\portfolio\portfolio\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ysspe\Documents\WorkSpace\portfolio\portfolio\_Imports.razor"
using portfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ysspe\Documents\WorkSpace\portfolio\portfolio\_Imports.razor"
using portfolio.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-y5pde0k6jk");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "main");
            __builder.AddAttribute(5, "b-y5pde0k6jk");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "header");
            __builder.AddAttribute(8, "b-y5pde0k6jk");
            __builder.OpenComponent<portfolio.Shared.NavMenu>(9);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n        \r\n\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "section content px-4");
            __builder.AddAttribute(13, "b-y5pde0k6jk");
            __builder.AddContent(14, 
#nullable restore
#line 17 "C:\Users\ysspe\Documents\WorkSpace\portfolio\portfolio\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
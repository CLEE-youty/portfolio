#pragma checksum "C:\Users\ysspe\Documents\WorkSpace\portfolio\Components\Organisms\StandardPageList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0dd0a2f4d7f334c988f0f648705c1a8231f3616"
// <auto-generated/>
#pragma warning disable 1591
namespace portfolio.Components.Organisms
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ysspe\Documents\WorkSpace\portfolio\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ysspe\Documents\WorkSpace\portfolio\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ysspe\Documents\WorkSpace\portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ysspe\Documents\WorkSpace\portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ysspe\Documents\WorkSpace\portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ysspe\Documents\WorkSpace\portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ysspe\Documents\WorkSpace\portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ysspe\Documents\WorkSpace\portfolio\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ysspe\Documents\WorkSpace\portfolio\_Imports.razor"
using portfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ysspe\Documents\WorkSpace\portfolio\_Imports.razor"
using portfolio.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ysspe\Documents\WorkSpace\portfolio\_Imports.razor"
using portfolio.Components.Atoms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ysspe\Documents\WorkSpace\portfolio\_Imports.razor"
using portfolio.Components.Molecules;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ysspe\Documents\WorkSpace\portfolio\_Imports.razor"
using portfolio.Components.Organisms;

#line default
#line hidden
#nullable disable
    public partial class StandardPageList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div b-dpfpkfpq6v><div class=\"card-deck\" b-dpfpkfpq6v><div class=\"card\" b-dpfpkfpq6v><svg class=\"bd-placeholder-img card-img-top\" width=\"100%\" height=\"200\" xmlns=\"http://www.w3.org/2000/svg\" preserveAspectRatio=\"xMidYMid slice\" focusable=\"false\" role=\"img\" aria-label=\"Placeholder: Image cap\" b-dpfpkfpq6v><title b-dpfpkfpq6v>Placeholder</title><rect fill=\"#868e96\" width=\"100%\" height=\"100%\" b-dpfpkfpq6v></rect><text fill=\"#dee2e6\" dy=\".3em\" x=\"50%\" y=\"50%\" b-dpfpkfpq6v>Image cap</text></svg>\r\n            <div class=\"card-body\" b-dpfpkfpq6v><h5 class=\"card-title\" b-dpfpkfpq6v>Card title</h5>\r\n                <p class=\"card-text\" b-dpfpkfpq6v>This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>\r\n                <p class=\"card-text\" b-dpfpkfpq6v><small class=\"text-muted\" b-dpfpkfpq6v>Last updated 3 mins ago</small></p></div></div>\r\n        <div class=\"card\" b-dpfpkfpq6v><svg class=\"bd-placeholder-img card-img-top\" width=\"100%\" height=\"200\" xmlns=\"http://www.w3.org/2000/svg\" preserveAspectRatio=\"xMidYMid slice\" focusable=\"false\" role=\"img\" aria-label=\"Placeholder: Image cap\" b-dpfpkfpq6v><title b-dpfpkfpq6v>Placeholder</title><rect fill=\"#868e96\" width=\"100%\" height=\"100%\" b-dpfpkfpq6v></rect><text fill=\"#dee2e6\" dy=\".3em\" x=\"50%\" y=\"50%\" b-dpfpkfpq6v>Image cap</text></svg>\r\n            <div class=\"card-body\" b-dpfpkfpq6v><h5 class=\"card-title\" b-dpfpkfpq6v>Card title</h5>\r\n                <p class=\"card-text\" b-dpfpkfpq6v>This card has supporting text below as a natural lead-in to additional content.</p>\r\n                <p class=\"card-text\" b-dpfpkfpq6v><small class=\"text-muted\" b-dpfpkfpq6v>Last updated 3 mins ago</small></p></div></div>\r\n        <div class=\"card\" b-dpfpkfpq6v><svg class=\"bd-placeholder-img card-img-top\" width=\"100%\" height=\"200\" xmlns=\"http://www.w3.org/2000/svg\" preserveAspectRatio=\"xMidYMid slice\" focusable=\"false\" role=\"img\" aria-label=\"Placeholder: Image cap\" b-dpfpkfpq6v><title b-dpfpkfpq6v>Placeholder</title><rect fill=\"#868e96\" width=\"100%\" height=\"100%\" b-dpfpkfpq6v></rect><text fill=\"#dee2e6\" dy=\".3em\" x=\"50%\" y=\"50%\" b-dpfpkfpq6v>Image cap</text></svg>\r\n            <div class=\"card-body\" b-dpfpkfpq6v><h5 class=\"card-title\" b-dpfpkfpq6v>Card title</h5>\r\n                <p class=\"card-text\" b-dpfpkfpq6v>This is a wider card with supporting text below as a natural lead-in to additional content. This card has even longer content than the first to show that equal height action.</p>\r\n                <p class=\"card-text\" b-dpfpkfpq6v><small class=\"text-muted\" b-dpfpkfpq6v>Last updated 3 mins ago</small></p></div></div></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
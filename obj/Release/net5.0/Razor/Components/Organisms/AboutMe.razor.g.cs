#pragma checksum "C:\Users\ysspe\Documents\WorkSpace\portfolio\Components\Organisms\AboutMe.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3a43a128f7b93f64d94d0017f8b3aec0089d373"
// <auto-generated/>
#pragma warning disable 1591
namespace portfolio.Components.Organisms
{
    #line hidden
    using System;
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
#line 13 "C:\Users\ysspe\Documents\WorkSpace\portfolio\_Imports.razor"
using portfolio.Components.Atoms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ysspe\Documents\WorkSpace\portfolio\_Imports.razor"
using portfolio.Components.Molecules;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ysspe\Documents\WorkSpace\portfolio\_Imports.razor"
using portfolio.Components.Organisms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ysspe\Documents\WorkSpace\portfolio\_Imports.razor"
using BlazorLang;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ysspe\Documents\WorkSpace\portfolio\Components\Organisms\AboutMe.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    public partial class AboutMe : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "b-e6j2rtgjah");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "about_shadow");
            __builder.AddAttribute(4, "b-e6j2rtgjah");
            __builder.OpenComponent<portfolio.Components.Atoms.Headding>(5);
            __builder.AddAttribute(6, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "C:\Users\ysspe\Documents\WorkSpace\portfolio\Components\Organisms\AboutMe.razor"
                          Title

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 6 "C:\Users\ysspe\Documents\WorkSpace\portfolio\Components\Organisms\AboutMe.razor"
         foreach (var item in byViewContent)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<portfolio.Components.Molecules.ByViewList>(7);
            __builder.AddAttribute(8, "Item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorLang.ByView>(
#nullable restore
#line 8 "C:\Users\ysspe\Documents\WorkSpace\portfolio\Components\Organisms\AboutMe.razor"
                               item

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 9 "C:\Users\ysspe\Documents\WorkSpace\portfolio\Components\Organisms\AboutMe.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\ysspe\Documents\WorkSpace\portfolio\Components\Organisms\AboutMe.razor"
       
    public string Title = "About Me";
    private List<ByView> byViewContent { get; set; }
    protected override void OnInitialized()
    {
        this.byViewContent = new List<ByView>();
        this.byViewContent.Add(new ByView()
        {
            ByViewTitle = "Who am I",
            ByViewHeadding = "?????? ??????",
            ByViewSmallHeadding = "YUTA SAITO",
            ByViewDescription = "1996????????????????????????????????????????????????????????????IT?????????????????????????????????????????????????????????????????????????????????????????????????????????????????????WEB??????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????Unity??????????????????????????????????????????????????????"
        });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\ysspe\Documents\WorkSpace\portfolio\Components\Molecules\SoloViewList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cec8e90df34f53c8fbe7e86ac4c56dd939c5fdb7"
// <auto-generated/>
#pragma warning disable 1591
namespace portfolio.Components.Molecules
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
    public partial class SoloViewList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "b-mjxg3gtdvs");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "text-light text-center");
            __builder.AddAttribute(4, "b-mjxg3gtdvs");
            __builder.OpenElement(5, "h3");
            __builder.AddAttribute(6, "class", "pt-4");
            __builder.AddAttribute(7, "b-mjxg3gtdvs");
            __builder.AddContent(8, 
#nullable restore
#line 4 "C:\Users\ysspe\Documents\WorkSpace\portfolio\Components\Molecules\SoloViewList.razor"
                          Item.ViewTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddMarkupContent(10, "<div class=\"mw-320 mx-auto pt-4\" b-mjxg3gtdvs><img class=\"card-img rounded-circle\" src=\"data:image/svg+xml,%3csvg xmlns=\'http://www.w3.org/2000/svg\' version=\'1.1\' xmlns:xlink=\'http://www.w3.org/1999/xlink\' xmlns:svgjs=\'http://svgjs.com/svgjs\' width=\'560\' height=\'560\' preserveAspectRatio=\'none\' viewBox=\'0 0 560 560\'%3e%3cg mask=\'url(%26quot%3b%23SvgjsMask1066%26quot%3b)\' fill=\'none\'%3e%3crect width=\'560\' height=\'560\' x=\'0\' y=\'0\' fill=\'rgba(255%2c 77%2c 90%2c 1)\'%3e%3c/rect%3e%3cpath d=\'M0%2c163.965C32.944%2c160.493%2c65.57%2c162.17%2c96.348%2c149.921C132.393%2c135.576%2c169.514%2c119.336%2c191.846%2c87.613C216.191%2c53.031%2c233.283%2c9.1%2c224.622%2c-32.296C216.071%2c-73.169%2c181.919%2c-104.552%2c146.887%2c-127.278C116.815%2c-146.786%2c77.893%2c-138.138%2c43.905%2c-149.527C7.959%2c-161.572%2c-19.843%2c-200.307%2c-57.479%2c-195.756C-95.444%2c-191.165%2c-120.483%2c-154.992%2c-146.053%2c-126.556C-172.053%2c-97.642%2c-200.849%2c-68.161%2c-206.775%2c-29.73C-212.723%2c8.841%2c-194.963%2c46.14%2c-178.111%2c81.341C-161.518%2c116.002%2c-145.206%2c155.531%2c-110.346%2c171.702C-76.206%2c187.539%2c-37.428%2c167.909%2c0%2c163.965\' fill=\'%23d80010\'%3e%3c/path%3e%3cpath d=\'M560 735.762C595.563 739.031 633.3 740.067 664.049 721.904 695.238 703.481 712.237 669.342 727.812 636.637 743.602 603.481 764.6279999999999 567.33 754.471 532.039 744.423 497.127 702.293 484.657 676.662 458.911 653.327 435.471 639.2570000000001 404.131 610.633 387.55899999999997 576.923 368.043 538.991 351.95799999999997 500.345 356.832 459.04 362.041 415.046 379.90999999999997 392.70799999999997 415.041 370.762 449.556 392.394 494.582 386.978 535.123 381.639 575.083 343.839 614.403 361.214 650.782 378.64 687.268 430.379 687.948 467.558 703.842 498.153 716.921 526.867 732.716 560 735.762\' fill=\'%23ffc1c6\'%3e%3c/path%3e%3c/g%3e%3cdefs%3e%3cmask id=\'SvgjsMask1066\'%3e%3crect width=\'560\' height=\'560\' fill=\'white\'%3e%3c/rect%3e%3c/mask%3e%3c/defs%3e%3c/svg%3e\" b-mjxg3gtdvs></div>\r\n        ");
            __builder.OpenElement(11, "h3");
            __builder.AddAttribute(12, "class", "pt-4");
            __builder.AddAttribute(13, "b-mjxg3gtdvs");
            __builder.AddContent(14, 
#nullable restore
#line 8 "C:\Users\ysspe\Documents\WorkSpace\portfolio\Components\Molecules\SoloViewList.razor"
                          Item.ViewHeadding

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "h4");
            __builder.AddAttribute(17, "b-mjxg3gtdvs");
            __builder.AddContent(18, 
#nullable restore
#line 9 "C:\Users\ysspe\Documents\WorkSpace\portfolio\Components\Molecules\SoloViewList.razor"
             Item.ViewSmallHeadding

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "p");
            __builder.AddAttribute(21, "class", "pt-4");
            __builder.AddAttribute(22, "b-mjxg3gtdvs");
            __builder.AddContent(23, 
#nullable restore
#line 10 "C:\Users\ysspe\Documents\WorkSpace\portfolio\Components\Molecules\SoloViewList.razor"
                         Item.ViewDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\ysspe\Documents\WorkSpace\portfolio\Components\Molecules\SoloViewList.razor"
       
    [Parameter]
    public View Item { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

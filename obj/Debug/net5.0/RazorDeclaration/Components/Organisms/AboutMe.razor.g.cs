// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\ysspe\Documents\WorkSpace\portfolio\Components\Organisms\AboutMe.razor"
       
    public string Title = "About Me";
    private List<ByView> byViewContent { get; set; }
    protected override void OnInitialized()
    {
        this.byViewContent = new List<ByView>();
        this.byViewContent.Add(new ByView()
        {
            ByViewTitle = "Who am I",
            ByViewHeadding = "齋藤 雄太",
            ByViewSmallHeadding = "YUTA SAITO",
            ByViewDescription = "1996年、神奈川県生まれ。大学を卒業後、都内のIT関連会社でフロントエンドエンジニアとして就職。大手飲食店決済サービス関連会社のWEB運用・保守業務に従事しながら、社内の経営、教育、人事、企画など様々な業務に取り組む。他方で、Unityを使った個人のゲーム開発活動も開始。"
        });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

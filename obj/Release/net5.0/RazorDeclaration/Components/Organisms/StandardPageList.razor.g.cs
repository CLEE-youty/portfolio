// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class StandardPageList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\ysspe\Documents\WorkSpace\portfolio\Components\Organisms\StandardPageList.razor"
       
    /* cardコンテンツ一覧 */
    /*
        1. CLEE.inc HP https://clee-inc.com/
            個人ゲーム開発組織「CLEE」のホームページです。絶賛工事中。
        2. Veritas (ホラーゲーム) https://github.com/CLEE-inc/clee-veritas
            探索型ホラー FPS「Veritas」絶賛工事中。
        3. EDM (ホラーゲーム) https://github.com/CLEE-inc/EDM-DL
            短編ホラー「EDM」。DLファイル作成中。
        4. duplicateChecker https://github.com/CLEE-youty/duplicateChecker
        5. Questa https://alchemy-questa.herokuapp.com/
        6. do one action https://github.com/alchemyyouty/do-one-action
    */

    public string Title = "Works";
    public string CardFlexModifier = "card--3column";

    private List<Book> books { get; set; } = new List<Book>();

    protected override async Task OnInitializedAsync()
    {
        var items = await Http.GetFromJsonAsync<List<Book>>("list-date/ContentList.json");
        this.books = items;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
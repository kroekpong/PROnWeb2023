#pragma checksum "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\Utilities\Logout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c543536518052082f01033b58d0aeec8507b3746"
// <auto-generated/>
#pragma warning disable 1591
namespace PrOnWeb.Pages.Utilities
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using PrOnWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using PrOnWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using PrOnWeb.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/logmeout")]
    public partial class Logout : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\Utilities\Logout.razor"
      
    protected override async Task OnInitializedAsync()
    {        
        navigationManager.NavigateTo("Identity/Account/LogOut", forceLoad: true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591

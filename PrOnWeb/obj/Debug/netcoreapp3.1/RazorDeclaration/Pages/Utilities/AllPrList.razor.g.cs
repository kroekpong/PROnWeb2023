// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\Utilities\AllPrList.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\Utilities\AllPrList.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\Utilities\AllPrList.razor"
           [Authorize(Roles = "Administrators,PF,PH")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/allprlist")]
    public partial class AllPrList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\Utilities\AllPrList.razor"
       
    SfGrid<vPRHeader> gridRef;
    List<vPRHeader> prHeaders = new List<vPRHeader>();


    protected override async Task OnInitializedAsync()
    {
        prHeaders = await prMainService.GetvPrHeadersAsync("ALL");
        prHeaders = prHeaders.Where(x => x.Pr_No.Substring(0, 2) != "L-").ToList();
    }

    private void Navigate(vPRHeader prHeader1)
    {
        navigationManager.NavigateTo($"prform/{prHeader1.Id}");
    }

    public async Task ToolbarClickHandler(Syncfusion.Blazor.Navigations.ClickEventArgs args)
    {
        if (args.Item.Id == "Grid_AllPr_excelexport") //Id is combination of Grid's ID and itemname
        {
            await this.gridRef.ExcelExport();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrMainService prMainService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrDataService prDataService { get; set; }
    }
}
#pragma warning restore 1591
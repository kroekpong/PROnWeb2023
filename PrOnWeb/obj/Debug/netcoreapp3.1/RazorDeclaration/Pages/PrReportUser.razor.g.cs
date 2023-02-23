// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PrOnWeb.Pages
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
#line 11 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\PrReportUser.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\PrReportUser.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\PrReportUser.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\PrReportUser.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\PrReportUser.razor"
using PrOnWeb.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\PrReportUser.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\PrReportUser.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/prReportUser")]
    public partial class PrReportUser : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 132 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\PrReportUser.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    [CascadingParameter]
    private Task<AuthenticationState> _authState { get; set; }
    private AuthenticationState authState;
    ClaimsPrincipal MyClaims = new ClaimsPrincipal();
    SfGrid<PrReportModel> GridRef;

    List<PrReportModel> PrReports;
    private string fullName;

    [CascadingParameter]
    public MainLayout Layout { get; set; }

    public DateTime? StartValue { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
    public DateTime? EndValue { get; set; }
    string myUserId;
    string myCompanies;
    string myDepartment;
    string mySection;
    string filter;
    bool isChecked = false;

    protected override async Task OnInitializedAsync()
    {
        //vPrLists = await prDataService.GetVPrListAsync();

        authState = await _authState;
        MyClaims = (await _authState).User;

        if (MyClaims.Identity.IsAuthenticated)
        {
            //Layout.SidebarToggle = false;
            EndValue = StartValue.Value.AddMonths(1);
            //var myUserName = MyClaims.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name).Value;
            //myUserId = Int16.Parse(MyClaims.Claims.FirstOrDefault(c => c.Type == "PrUserId").Value);

            var thisUser = _UserManager.Users.FirstOrDefault(x => x.UserName == MyClaims.Identity.Name);
            if (thisUser == null)
            {
                navigationManager.NavigateTo("Identity/Account/Login?returnUrl=~/" +
                navigationManager.ToBaseRelativePath(navigationManager.Uri), true);
            }
            else
            {
                myUserId = thisUser.PrUserId;
                myCompanies = await prDataService.GetCompaniesFromUserIdAsync(Int32.Parse(myUserId));
                myDepartment = await prDataService.GetDepartmentFromUserIdAsync(Int32.Parse(myUserId));
                //filter = "'CSSE','CSIT','CSQC','CSAD','PAAC','PASM','PADM','PAL3','PAL4','PAL5','PAL2','PAL6','PDHO','PDRY','RN','PCOMP'";
                PrReports = await prDataService.GetPrReportDeptAsync(filter, myCompanies, myDepartment);
            }

        }
    }

    private async Task clickFilter()
    {
        string startDate = (StartValue ?? DateTime.Now).ToString("dd/MM/yyyy");
        string endDate = (EndValue ?? DateTime.Now).ToString("dd/MM/yyyy");
        PrReports = await prDataService.GetPrReportDeptAsync(filter, myCompanies, myDepartment, startDate, endDate);
        GridRef.Refresh();
    }

    private async Task onClickCheck()
    {
        isChecked = !isChecked;
        if (!isChecked)
        {
            PrReports = await prDataService.GetPrReportDeptAsync(filter, myCompanies, myDepartment);
            GridRef.Refresh();
        }
    }

    public async Task ToolbarClickHandler(Syncfusion.Blazor.Navigations.ClickEventArgs args)
    {
        if (args.Item.Id == "Grid_PrReport_excelexport") //Id is combination of Grid's ID and itemname
        {
            await this.GridRef.ExcelExport();
        }
    }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> _UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrMainService prMainService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrDataService prDataService { get; set; }
    }
}
#pragma warning restore 1591

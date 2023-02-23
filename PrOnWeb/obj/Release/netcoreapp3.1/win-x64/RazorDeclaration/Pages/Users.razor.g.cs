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
#line 1 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using PrOnWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using PrOnWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using PrOnWeb.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\bunlue\source\repos\PrOnWeb\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Users.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/users")]
    public partial class Users : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Users.razor"
       
    SfGrid<UserTable> Grid;
    List<UserTable> allUsers;

    protected override async Task OnInitializedAsync()
    {
        allUsers = await prData.GetUserTablesAsync();
    }

    public async Task SelectedRowCellIndex()
    {
        var value = await this.Grid.GetSelectedRecords();
        navigationManager.NavigateTo($"/UserProfile/{value.First().Pr_User_Id}");
    }

    //public async Task RegisNewUser()
    //{
    //    int thisPrUserId;
    //    int maxPrUserId = 0;
    //    foreach (ApplicationUser user in allUser)
    //    {
    //        if (user.PrUserId != "" && user.PrUserId != null)
    //        {
    //            thisPrUserId = Int32.Parse(user.PrUserId);
    //            if (thisPrUserId > maxPrUserId)
    //            {
    //                maxPrUserId = thisPrUserId;
    //            }
    //        }
    //    }

    //    WorkflowAutho workflowAutho;

    //    foreach (ApplicationUser user in allUser)
    //    {
    //        if (user.PrUserId == null || user.PrUserId == "")
    //        {
    //            // gen new PrUserID
    //            maxPrUserId += 1;
    //            user.PrUserId = maxPrUserId.ToString();
    //            await _UserManager.UpdateAsync(user);
    //            // create new WorkflowAuthos
    //            //workflowAutho = new WorkflowAutho
    //            //{
    //            //    User_Id = maxPrUserId
    //            //};
    //            //await prDataService.CreateWorkflowAuthoAsync(workflowAutho);
    //        }
    //    }
    //}

    public async Task ActionBegin(ActionEventArgs<UserTable> args)
    {
        if (args.RequestType == Syncfusion.Blazor.Grids.Action.BeginEdit)
        {
            // Triggers before editing operation starts
        }
        else if (args.RequestType == Syncfusion.Blazor.Grids.Action.Add)
        {
            // Triggers before add operation starts
        }
        else if (args.RequestType == Syncfusion.Blazor.Grids.Action.Cancel)
        {
            // Triggers before cancel operation starts
        }
        else if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
        {
            // Triggers before save operation starts
            //args.Cancel = true;
            //if (args.Action == "Edit")
            //{
            //    SelectedRole = args.Data;
            //    await UpdateRole();
            //}
            //else
            //{
            //    RoleName = args.Data.Name;
            //    await ActionCreateRole();
            //}
            //allRole = _RoleManager.Roles.ToList();
            //Grid.Refresh();

        }
        else if (args.RequestType == Syncfusion.Blazor.Grids.Action.Delete)
        {
            // Triggers before delete operation starts
            //this.ConfirmDlgVisible = true;
            //args.Cancel = true;            //cancel the delete action
            //SelectedRole = args.Data;
        }


    }
    public async Task ActionComplete(ActionEventArgs<UserTable>  args)
    {
        if (args.RequestType == Syncfusion.Blazor.Grids.Action.BeginEdit)
        {
            // Triggers once editing operation completes
        }
        else if (args.RequestType == Syncfusion.Blazor.Grids.Action.Add)
        {
            //
        }
        else if (args.RequestType == Syncfusion.Blazor.Grids.Action.Cancel)
        {
            // Triggers once cancel operation completes
        }
        else if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
        {
            // Triggers once save operation completes

        }
        else if (args.RequestType == Syncfusion.Blazor.Grids.Action.Delete)
        {
            // Triggers once delete operation completes
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrDataService prData { get; set; }
    }
}
#pragma warning restore 1591
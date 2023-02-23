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
#line 2 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\PrItemDetail.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\PrItemDetail.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\PrItemDetail.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\PrItemDetail.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\PrItemDetail.razor"
using PrOnWeb.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\PrItemDetail.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    public partial class PrItemDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 197 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\PrItemDetail.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    [CascadingParameter]
    private Task<AuthenticationState> _authState { get; set; }
    private AuthenticationState authState;
    ClaimsPrincipal CurrentUser = new ClaimsPrincipal();
    int myUserId;
    int thisPrId;

    [Parameter] public PRItem prItem { get; set; }
    [Parameter] public EventCallback<string> OnClick { get; set; }

    bool isPM = false;
    bool isShowButton = false;
    bool NeedCoSign = true;
    bool NeedAccounting = true;
    string CoSignStatus = "Pending";
    string AccountingStatus = "Pending";
    string SMStatus = "Pending";
    string DMStatus = "Pending";
    string prQty = "0.00";
    string prReqDate;
    List<UserTable> userTables;
    Approval_flow myApproval_flow;
    List<Approval_flow> approval_Flows;

    float ItemAmt;

    protected override async Task OnInitializedAsync()
    {
        authState = await _authState;
        CurrentUser = (await _authState).User;

        if (CurrentUser.Identity.IsAuthenticated)
        {
            myUserId = Int16.Parse(CurrentUser.Claims.FirstOrDefault(c => c.Type == "PrUserId").Value);
            // userTable NOT USE???
            List<WorkflowAutho> workflowAuthos = await prDataService.GetWorkflowAuthoAsync(myUserId);
            foreach (WorkflowAutho workflowAutho in workflowAuthos)
            {
                if (workflowAutho.IsPM == true)
                {
                    isPM = true;
                }
            }
        }
        // userTables NOT USE???
        List<vWorkflowAuthoName> staffWFAs = await prDataService.GetUserWorkflowAuthoNameAsync("isPS");
        userTables = new List<UserTable>();
        foreach (vWorkflowAuthoName staffWFA in staffWFAs)
        {
            UserTable _userTable = new UserTable();
            _userTable.Id = staffWFA.Id ?? 0;
            _userTable.UserName = staffWFA.UserName;

            userTables.Add(_userTable);
        }
    }
    public void CloseMe()
    {
        this.IsVisible = false;
    }

    public string DropVal = ""; //demo
    public string ChangeValue { get; set; } = ""; //demo
    public async Task OnChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
    }

    public async Task InitThisItem(PRItem thisPrItem, int PrId)
    {
        thisPrId = PrId;
        var statusName = new Dictionary<string, string>()
{
            {"N", "Pending"},
            {"M", "Question"},
            {"A", "Approved"},
            {"R", "Rejected"}
        };
        if (thisPrItem != null)
        {
            prItem = thisPrItem;
            prQty = thisPrItem.Quantity.ToString("0.00");
            ItemAmt = thisPrItem.Quantity * thisPrItem.Price_PR / thisPrItem.Price_Unit;
            prReqDate = thisPrItem.Requistion_date.ToShortDateString();
            NeedAccounting = thisPrItem.Need_Accounting;
            NeedCoSign = thisPrItem.Need_cosign;
            // get current Item status
            approval_Flows = await prDataService.GetApprovalFlowAsync(thisPrItem.Id);
            foreach (Approval_flow approval_Flow in approval_Flows)
            {
                switch (approval_Flow.Approver_role)
                {
                    case "C":
                        CoSignStatus = statusName[approval_Flow.Status];
                        break;
                    case "A":
                        AccountingStatus = statusName[approval_Flow.Status];
                        break;
                    case "S":
                        SMStatus = statusName[approval_Flow.Status];
                        break;
                    case "D":
                        DMStatus = statusName[approval_Flow.Status];
                        break;
                    default:
                        break;
                }
                // if approver_role = A and status = N or M and I'm isAccounting then ShowButton
                if (approval_Flow.Approver_role == "A" && approval_Flow.Status == "N")
                {
                    List<WorkflowAutho> x = await prDataService.GetWorkflowAuthoAsync(myUserId);
                    if (x.Any()) // some member
                    {
                        if (x.First().IsAccount)
                        {
                            myApproval_flow = approval_Flow;
                            isShowButton = true;
                        };
                    }
                }
                if (approval_Flow.Approver_role == "C" && approval_Flow.Status == "N")
                {
                    List<WorkflowAutho> x = await prDataService.GetWorkflowAuthoAsync(myUserId);
                    if (x.Any()) // some member
                    {
                        if (x.First().IsCoSign)
                        {
                            myApproval_flow = approval_Flow;
                            isShowButton = true;
                        };
                    }
                }
                if (approval_Flow.Approver_id == myUserId)
                {
                    myApproval_flow = approval_Flow;
                    if (approval_Flow.Status == "N")
                    {
                        isShowButton = true;
                    }
                }
                //else
                //    isShowButton = false;
            }
            await GetUploadFileList();
            this.StateHasChanged();
        }
    }

    private async Task SetApproveStatusA()
    {
        await SetApproveFlowStatusAsync("A");
    }

    private async Task SetApproveStatusR()
    {
        await SetApproveFlowStatusAsync("R");
    }

    private async Task SetApproveFlowStatusAsync(string status)
    {
        isShowButton = false;
        myApproval_flow.Status = status;
        myApproval_flow.When_end = DateTime.Now;
        await prDataService.UpdateApprovalFlowAsync(myApproval_flow);
        // Enable Next Approval Flow
        Approval_flow resultApproval_flow;
        if (status == "A") // only Approved
        {
            switch (myApproval_flow.Approver_role)
            {
                case "A":
                    // enable "C"
                    resultApproval_flow = approval_Flows.Find(x => x.Approver_role == "C");
                    if (resultApproval_flow != null)
                    {
                        resultApproval_flow.Is_disabled = false;
                        await prDataService.UpdateApprovalFlowAsync(myApproval_flow);
                    };
                    break;
                case "C":
                    resultApproval_flow = approval_Flows.Find(x => x.Approver_role == "S");
                    if (resultApproval_flow != null)
                    {
                        resultApproval_flow.Is_disabled = false;
                        await prDataService.UpdateApprovalFlowAsync(myApproval_flow);
                    };
                    break;
                case "S":
                    resultApproval_flow = approval_Flows.Find(x => x.Approver_role == "D");
                    if (resultApproval_flow != null)
                    {
                        resultApproval_flow.Is_disabled = false;
                        await prDataService.UpdateApprovalFlowAsync(myApproval_flow);
                    };
                    break;
                case "D":
                    resultApproval_flow = approval_Flows.Find(x => x.Approver_role == "L3");
                    if (resultApproval_flow != null)
                    {
                        resultApproval_flow.Is_disabled = false;
                        await prDataService.UpdateApprovalFlowAsync(myApproval_flow);
                    };
                    break;
                default:
                    break;
            }
        }
        //Update PrHeader Status
        await CheckAndSetPrStatus();
        this.IsVisible = false;
        navigationManager.NavigateTo("/prform/" + thisPrId);
        this.StateHasChanged();
    }

    private async Task CheckAndSetPrStatus()
    {
        // อันนี้ดูจาก PrItem รวมของทุก Item ใน Pr เดียวกัน
        List<Approval_flow> approval_Flows = await prDataService.GetApprovalFlowPrHeadAsync(thisPrId);
        Boolean allDMVerified = true;
        Boolean L3Available = false;

        //Boolean availableDM = false;
        // DM approve --> L3 or Purchasing

        foreach (Approval_flow approval_Flow in approval_Flows)
        {
            if (approval_Flow.Approver_role == "D")
            {
                if (approval_Flow.Status != "A")
                {
                    allDMVerified = false;
                }
            }
            if (approval_Flow.Approver_role == "L3")
            { L3Available = true; }
        }
        if (allDMVerified == true)
        {
            if (L3Available == true)
            {
                await prDataService.SetPrStatus(thisPrId, "PAL3");
            }
            else
                await prDataService.SetPrStatus(thisPrId, "PURS");
        }

        //foreach (Approval_flow approval_flow in approval_Flows)
        //{
        //    if (approval_flow.Status != "A")
        //    {
        //        switch (approval_flow.Approver_role)
        //        {
        //            case "A": // A ของ รายการนี้ Approve แล้ว

        //            case "C":
        //                allACVerified = false;
        //                break;
        //            case "S":
        //                allSMVerified = false;
        //                break;
        //            case "D":
        //                allDMVerified = false;
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //else
        //{
        //    if (approval_flow.Approver_role == "S")
        //    {
        //        availableSM = true;
        //    }
        //    if (approval_flow.Approver_role == "D")
        //    {
        //        availableDM = true;
        //    }
        //}

        //    if (allDMVerified) // && availableDM)
        //    {
        //        // determine next step ---> L3 or Purchasing

        //    }
        //    else if (allSMVerified) // && availableSM)
        //    {
        //        await SetPendingApproverSMDM(thisPrId, "PADM");
        //}
        //    else
        //    await SetPendingApproverSMDM(thisPrId, "PASM");
    }

    // NextStatus = PASM, PADM
    private async Task SetPendingApproverSMDM(int PrId, string NextStatus)
    {
        //int SmDm = 0;
        //await prDataService.SetPrStatus(PrId, NextStatus);
        //switch (NextStatus)
        //{
        //    case "PASM":
        //        //who is our SM
        //        SmDm = await prDataService.GetSmDmUserId(PrId, true);
        //        await prDataService.GenerateApprovalFlow(prItem, "S", SmDm, 0, "N");
        //        break;
        //    case "PADM":
        //        //who is our DM
        //        SmDm = await prDataService.GetSmDmUserId(PrId, false);
        //        await prDataService.GenerateApprovalFlow(prItem, "D", SmDm, 0, "N");
        //        break;
        //    default:
        //        break;
        //}
    }

    // Upload File
    private string Target { get; set; } = "body";
    private bool IsVisibleChild { get; set; } = false;
    private void OpenUploadDialog()
    {
        this.Target = "#dialog.e-dialog";
        this.IsVisibleChild = true;
    }

    List<UploadFile> uploadFiles;
    private async Task GetUploadFileList()
    {
        uploadFiles = await prDataService.GetUploadFileListAsync(prItem.Id);
    }
    public bool IsVisible { get; set; } = false;
    private void OnDialogBtnClick()
    {
        IsVisible = false;
    }
    private void OnOpenButtonClick()
    {
        IsVisible = true;
    }

    private void OnRnClick()
    {
        IsVisible = false;
        navigationManager.NavigateTo($"/rnform/{thisPrId}/{prItem.Item_No}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrDataService prDataService { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83ca9bb4e2e66ab114593ff04bcd035c72c6ceb0"
// <auto-generated/>
#pragma warning disable 1591
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
#line 12 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
using PrOnWeb.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/rnlist")]
    public partial class RnList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 11 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
 if (vReturningNotes == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 14 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<h3>Returning Note List</h3>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddMarkupContent(5, "\r\n        ");
            global::__Blazor.PrOnWeb.Pages.RnList.TypeInference.CreateSfCheckBox_0(__builder, 6, 7, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
                                                         ActiveClick

#line default
#line hidden
#nullable disable
            ), 8, 
#nullable restore
#line 19 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
                                    isActive

#line default
#line hidden
#nullable disable
            , 9, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => isActive = __value, isActive)), 10, () => isActive, 11, (__builder2) => {
                __builder2.AddContent(12, "Show only Active transaction");
            }
            );
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            global::__Blazor.PrOnWeb.Pages.RnList.TypeInference.CreateSfGrid_1(__builder, 15, 16, "Grid_RnList", 17, 
#nullable restore
#line 21 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
                                                         vRnList

#line default
#line hidden
#nullable disable
            , 18, 
#nullable restore
#line 21 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
                                                                               true

#line default
#line hidden
#nullable disable
            , 19, 
#nullable restore
#line 21 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
                                                                                                     true

#line default
#line hidden
#nullable disable
            , 20, 
#nullable restore
#line 21 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
                                                                                                                          true

#line default
#line hidden
#nullable disable
            , 21, 
#nullable restore
#line 22 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
                          true

#line default
#line hidden
#nullable disable
            , 22, 
#nullable restore
#line 22 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
                                           new List<string>() { "ExcelExport", "Search" }

#line default
#line hidden
#nullable disable
            , 23, 
#nullable restore
#line 22 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
                                                                                                              true

#line default
#line hidden
#nullable disable
            , 24, (__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenComponent<global::Syncfusion.Blazor.Grids.GridEvents<VRnList>>(26);
                __builder2.AddAttribute(27, "OnToolbarClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Syncfusion.Blazor.Navigations.ClickEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Syncfusion.Blazor.Navigations.ClickEventArgs>(this, 
#nullable restore
#line 23 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
                                    ToolbarClickHandler

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenComponent<global::Syncfusion.Blazor.Grids.GridColumns>(29);
                __builder2.AddAttribute(30, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(31, "\r\n            ");
                    __builder3.OpenComponent<global::Syncfusion.Blazor.Grids.GridColumn>(32);
                    __builder3.AddAttribute(33, "Field", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 25 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
                               nameof(VRnList.Id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "HeaderText", "RN #");
                    __builder3.AddAttribute(35, "Template", (global::Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(36, "\r\n");
#nullable restore
#line 27 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
                      
                        var Rn0 = (context as VRnList);

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(37, "                        ");
                        __builder4.OpenElement(38, "div");
                        __builder4.OpenElement(39, "a");
                        __builder4.AddAttribute(40, "href", 
#nullable restore
#line 29 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
                                       navigationManager.Uri

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(41, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
                                                                          () => Navigate(Rn0)

#line default
#line hidden
#nullable disable
                        ));
#nullable restore
#line 29 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
__builder4.AddContent(42, Rn0.Rn_Id);

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(43, "\r\n");
                        __builder4.AddContent(44, "                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\r\n            ");
                    __builder3.OpenComponent<global::Syncfusion.Blazor.Grids.GridColumn>(46);
                    __builder3.AddAttribute(47, "Field", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 33 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
                               nameof(VRnList.Rn_When)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(48, "HeaderText", "Date");
                    __builder3.AddAttribute(49, "Format", "d/M/yyyy");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\r\n            ");
                    __builder3.OpenComponent<global::Syncfusion.Blazor.Grids.GridColumn>(51);
                    __builder3.AddAttribute(52, "Field", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 34 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
                               nameof(VRnList.RnTypeName)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(53, "HeaderText", "Type");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\r\n            ");
                    __builder3.OpenComponent<global::Syncfusion.Blazor.Grids.GridColumn>(55);
                    __builder3.AddAttribute(56, "Field", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 35 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
                               nameof(VRnList.Rn_Memo1)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "HeaderText", "Description");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\r\n            ");
                    __builder3.OpenComponent<global::Syncfusion.Blazor.Grids.GridColumn>(59);
                    __builder3.AddAttribute(60, "Field", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 36 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
                               nameof(VRnList.Pr_Id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(61, "HeaderText", "PR #");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\r\n            ");
                    __builder3.OpenComponent<global::Syncfusion.Blazor.Grids.GridColumn>(63);
                    __builder3.AddAttribute(64, "Field", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 37 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
                               nameof(VRnList.CompanyName)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(65, "HeaderText", "Company");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(66, "\r\n            ");
                    __builder3.OpenComponent<global::Syncfusion.Blazor.Grids.GridColumn>(67);
                    __builder3.AddAttribute(68, "Field", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 38 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
                               nameof(VRnList.Department)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(69, "HeaderText", "Department");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\r\n            ");
                    __builder3.OpenComponent<global::Syncfusion.Blazor.Grids.GridColumn>(71);
                    __builder3.AddAttribute(72, "Field", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 39 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
                               nameof(VRnList.Section)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(73, "HeaderText", "Section");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(74, "\r\n            ");
                    __builder3.OpenComponent<global::Syncfusion.Blazor.Grids.GridColumn>(75);
                    __builder3.AddAttribute(76, "Field", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 40 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
                               nameof(VRnList.Rn_Status_Name)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(77, "HeaderText", "Status");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(78, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n    ");
            }
            , 80, (__value) => {
#nullable restore
#line 21 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
                                   gridRef = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(81, "\r\n");
#nullable restore
#line 43 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "D:\KHOTDEE_WORK\TPAC_TPCC\PR Online\PrOnWeb\PrOnWeb_No_Git\PrOnWeb\Pages\RnList.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    [CascadingParameter]
    private Task<AuthenticationState> _authState { get; set; }
    private AuthenticationState authState;
    ClaimsPrincipal MyClaims = new ClaimsPrincipal();

    List<VReturningNote> vReturningNotes;
    List<VRnList> vRnList;
    List<VRnList> allRnList;
    int myUserId;
    List<Master_Rn_Type> RnType;
    bool isActive = true;
    SfGrid<VRnList> gridRef;
    string myPD;
   

    public class VRnList : VReturningNote
    {
        public string RnTypeName { get; set; }
        public string CompanyName { get; set; }
        public string Department { get; set; }
        public string Section { get; set; }
        public string RNStatusName { get; set; }
    }


    public async Task<List<VRnList>> addVRN(List<VReturningNote> returningNotesToAdd)
    {
        var returningNotesAdded = new List<VRnList>();
        VRnList vrn0;
        vPRHeader vpr0;

        foreach (var item in returningNotesToAdd)
        {
            vpr0 = await prMainService.GetvPrHeaderAsync(item.Pr_Id);
            vrn0 = new VRnList()
            {
                Id = item.Id,
                Rn_Id = item.Rn_Id,
                Pr_Id = item.Pr_Id,
                Pr_Item_No = item.Pr_Item_No,
                Rn_Memo1 = item.Rn_Memo1,
                Rn_Memo2 = item.Rn_Memo2,
                Rn_Memo3 = item.Rn_Memo3,
                Rn_By = item.Rn_By,
                Rn_When = item.Rn_When,
                CompanyName = vpr0.Company,
                Department = vpr0.Department,
                Section = vpr0.Section,
                Rn_Status = item.Rn_Status,
                Rn_Status_Name = item.Rn_Status_Name,
                RnTypeName = RnType.Where(x => x.Id == item.Rn_Type).First().Rn_Type
            };
            returningNotesAdded.Add(vrn0);
        }
        return returningNotesAdded;
    }

    //===============================================================
    protected override async Task OnInitializedAsync()
    {
        authState = await _authState;
        MyClaims = (await _authState).User;

        if (MyClaims.Identity.IsAuthenticated)
        {
            //Layout.SidebarToggle = false;

            allRnList = new List<VRnList>();
            RnType = await prDataService.GetRnType();
            if (MyClaims.IsInRole("PSManager"))
            {
                if (MyClaims.IsInRole("PH"))
                {
                    myPD = "PDHO";
                }
                else // I'm int PF
                    myPD = "PDRY";
                // RN of PSMananager
                vReturningNotes = await prDataService.GetVRnListForManagerAsync(myPD);
                allRnList.AddRange(await addVRN(vReturningNotes));
            }
            else
            {
                // RN of My Name
                myUserId = Int16.Parse(MyClaims.Claims.FirstOrDefault(c => c.Type == "PrUserId").Value);
                vReturningNotes = await prDataService.GetVRnListFromUserIdAsync(myUserId);
                allRnList.AddRange(await addVRN(vReturningNotes));
            }


            vRnList = allRnList.Where(x => x.Rn_Status != "RNCL").ToList();
        }

    }
    private void Navigate(VReturningNote Rn0)
    {
        navigationManager.NavigateTo($"RnForm/V/{Rn0.Id}/0",true);
    }

    private void ActiveClick()
    {
        if (isActive == true)
        {
            isActive = false;
            vRnList = allRnList;
        }
        else
        {
            isActive = true;
            vRnList = allRnList.Where(x => x.Rn_Status != "RNCL").ToList();
        }
        gridRef.Refresh();

    }

    public async Task ToolbarClickHandler(Syncfusion.Blazor.Navigations.ClickEventArgs args)
    {
        if (args.Item.Id == "Grid_RnList_excelexport") //Id is combination of Grid's ID and itemname
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
namespace __Blazor.PrOnWeb.Pages.RnList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfCheckBox_0<TChecked>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TChecked __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TChecked> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TChecked>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Buttons.SfCheckBox<TChecked>>(seq);
        __builder.AddAttribute(__seq0, "onclick", __arg0);
        __builder.AddAttribute(__seq1, "Checked", __arg1);
        __builder.AddAttribute(__seq2, "CheckedChanged", __arg2);
        __builder.AddAttribute(__seq3, "CheckedExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateSfGrid_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<TValue> __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::System.Boolean __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8, int __seq9, System.Action<global::Syncfusion.Blazor.Grids.SfGrid<TValue>> __arg9)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "ID", __arg0);
        __builder.AddAttribute(__seq1, "DataSource", __arg1);
        __builder.AddAttribute(__seq2, "AllowPaging", __arg2);
        __builder.AddAttribute(__seq3, "AllowFiltering", __arg3);
        __builder.AddAttribute(__seq4, "AllowResizing", __arg4);
        __builder.AddAttribute(__seq5, "AllowSorting", __arg5);
        __builder.AddAttribute(__seq6, "Toolbar", __arg6);
        __builder.AddAttribute(__seq7, "AllowExcelExport", __arg7);
        __builder.AddAttribute(__seq8, "ChildContent", __arg8);
        __builder.AddComponentReferenceCapture(__seq9, (__value) => { __arg9((global::Syncfusion.Blazor.Grids.SfGrid<TValue>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

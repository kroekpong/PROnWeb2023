#pragma checksum "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77b336b3dd7f897f2014225523dda78dd324d797"
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
#line 1 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using PrOnWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using PrOnWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using PrOnWeb.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
           [Authorize(Roles = "Administrators,PF,PH")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/allprlist")]
    public partial class AllPrList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
 if (prHeaders == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p><em>No Data...</em></p>\r\n");
#nullable restore
#line 12 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<h3>All PR List</h3>\r\n");
            __builder.AddContent(4, "    ");
            __Blazor.PrOnWeb.Pages.Utilities.AllPrList.TypeInference.CreateSfGrid_0(__builder, 5, 6, "Grid_AllPr", 7, 
#nullable restore
#line 17 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                                                        prHeaders

#line default
#line hidden
#nullable disable
            , 8, 
#nullable restore
#line 17 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                                                                                true

#line default
#line hidden
#nullable disable
            , 9, 
#nullable restore
#line 17 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                                                                                                      true

#line default
#line hidden
#nullable disable
            , 10, 
#nullable restore
#line 17 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                                                                                                                           true

#line default
#line hidden
#nullable disable
            , 11, 
#nullable restore
#line 18 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                          true

#line default
#line hidden
#nullable disable
            , 12, 
#nullable restore
#line 18 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                                           new List<string>() { "Print", "ExcelExport","Search" }

#line default
#line hidden
#nullable disable
            , 13, 
#nullable restore
#line 18 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                                                                                                                      true

#line default
#line hidden
#nullable disable
            , 14, (__builder2) => {
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEvents<vPRHeader>>(16);
                __builder2.AddAttribute(17, "OnToolbarClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Navigations.ClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Navigations.ClickEventArgs>(this, 
#nullable restore
#line 19 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                                    ToolbarClickHandler

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridSortSettings>(19);
                __builder2.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(21, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridSortColumns>(22);
                    __builder3.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(24, "\r\n                ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Grids.GridSortColumn>(25);
                        __builder4.AddAttribute(26, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                                       nameof(vPRHeader.Id)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(27, "Direction", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.SortDirection>(
#nullable restore
#line 22 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                                                                       SortDirection.Descending

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(28, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddContent(30, "        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(31);
                __builder2.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(33, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(34);
                    __builder3.AddAttribute(35, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                               nameof(vPRHeader.Pr_No)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "HeaderText", "SAP PR");
                    __builder3.AddAttribute(37, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 25 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                                                                                      TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "Width", "100");
                    __builder3.AddAttribute(39, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(40, "\r\n");
#nullable restore
#line 27 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                      
                        var prHeader0 = (context as vPRHeader);

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(41, "                        ");
                        __builder4.OpenElement(42, "div");
                        __builder4.OpenElement(43, "a");
                        __builder4.AddAttribute(44, "href", 
#nullable restore
#line 29 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                                       navigationManager.Uri

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                                                                          () => Navigate(prHeader0)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(46, 
#nullable restore
#line 29 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                                                                                                       prHeader0.Pr_No

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(47, "\r\n");
                        __builder4.AddContent(48, "                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(50);
                    __builder3.AddAttribute(51, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                               nameof(vPRHeader.Company)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(52, "HeaderText", "Company");
                    __builder3.AddAttribute(53, "Width", "80");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(55);
                    __builder3.AddAttribute(56, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                               nameof(vPRHeader.Department)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "HeaderText", "Dept.");
                    __builder3.AddAttribute(58, "Width", "50");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(59, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(60);
                    __builder3.AddAttribute(61, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                               nameof(vPRHeader.Section)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(62, "HeaderText", "Sect.");
                    __builder3.AddAttribute(63, "Width", "50");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(65);
                    __builder3.AddAttribute(66, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                               nameof(vPRHeader.Pr_Date)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(67, "HeaderText", "PR Date");
                    __builder3.AddAttribute(68, "Width", "100");
                    __builder3.AddAttribute(69, "Format", "d/M/yyyy");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(71);
                    __builder3.AddAttribute(72, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                               nameof(vPRHeader.Requester)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(73, "HeaderText", "Requester");
                    __builder3.AddAttribute(74, "Width", "150");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(76);
                    __builder3.AddAttribute(77, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                               nameof(vPRHeader.Tracking_No)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(78, "HeaderText", "Tracking");
                    __builder3.AddAttribute(79, "Width", "100");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(80, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(81);
                    __builder3.AddAttribute(82, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                               nameof(vPRHeader.Plant)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(83, "HeaderText", "Plant");
                    __builder3.AddAttribute(84, "Width", "70");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(85, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(86);
                    __builder3.AddAttribute(87, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                               nameof(vPRHeader.Purchasing_Org)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(88, "HeaderText", "Pur Org");
                    __builder3.AddAttribute(89, "Width", "70");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(90, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(91);
                    __builder3.AddAttribute(92, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                               nameof(vPRHeader.Create_Date)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(93, "HeaderText", "Cr.Date");
                    __builder3.AddAttribute(94, "Width", "100");
                    __builder3.AddAttribute(95, "Format", "d/M/yyyy");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(96, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(97);
                    __builder3.AddAttribute(98, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                               nameof(vPRHeader.PrStatus)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(99, "HeaderText", "Status");
                    __builder3.AddAttribute(100, "Width", "150");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(101, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(102);
                    __builder3.AddAttribute(103, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                               nameof(vPRHeader.sPrAmt)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(104, "HeaderText", "Budget");
                    __builder3.AddAttribute(105, "Width", "200");
                    __builder3.AddAttribute(106, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 43 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                                                                                                   TextAlign.Right

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(107, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(108, "\r\n    ");
            }
            , 109, (__value) => {
#nullable restore
#line 17 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
                                  gridRef = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(110, "\r\n");
#nullable restore
#line 46 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"

}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(111, "\r\n");
            __builder.AddMarkupContent(112, "<style type=\"text/css\" class=\"cssStyles\">\r\n    .e-grid .e-headercell {\r\n        background-color: #CADAFA;\r\n    }\r\n\r\n    .e-extlink:before {\r\n        content: \'\\e785\';\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\Utilities\AllPrList.razor"
       
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
namespace __Blazor.PrOnWeb.Pages.Utilities.AllPrList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<TValue> __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::System.Boolean __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8, int __seq9, global::System.Action<global::Syncfusion.Blazor.Grids.SfGrid<TValue>> __arg9)
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

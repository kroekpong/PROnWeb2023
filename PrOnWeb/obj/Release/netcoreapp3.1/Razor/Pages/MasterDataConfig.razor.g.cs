#pragma checksum "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd33ba81b8b3d94d39340425ab660fa50931c9bb"
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
#line 13 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MasterData")]
    public partial class MasterDataConfig : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"bg-secondary p-2 h6 text-white font-weight-bolder\">\r\n    Organization Info\r\n</div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "content");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-4");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<h5>Company</h5>\r\n");
#nullable restore
#line 12 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
             if (Master_Orgs == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.AddMarkupContent(12, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 15 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                ");
            __Blazor.PrOnWeb.Pages.MasterDataConfig.TypeInference.CreateSfGrid_0(__builder, 14, 15, 
#nullable restore
#line 18 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                     Master_Orgs

#line default
#line hidden
#nullable disable
            , 16, 
#nullable restore
#line 18 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                 true

#line default
#line hidden
#nullable disable
            , 17, "500", 18, 
#nullable restore
#line 18 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                                              new List<string>() { "Add", "Edit", "Update", "Cancel" }

#line default
#line hidden
#nullable disable
            , 19, 
#nullable restore
#line 18 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                                                                                                                      true

#line default
#line hidden
#nullable disable
            , 20, (__builder2) => {
                __builder2.AddMarkupContent(21, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEditSettings>(22);
                __builder2.AddAttribute(23, "AllowAdding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "AllowDeleting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "AllowEditing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.EditMode>(
#nullable restore
#line 19 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                                                        EditMode.Dialog

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEvents<Master_Org>>(28);
                __builder2.AddAttribute(29, "OnActionComplete", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Grids.ActionEventArgs<Master_Org>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Grids.ActionEventArgs<Master_Org>>(this, 
#nullable restore
#line 20 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                  ActionComplete

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(31);
                __builder2.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(33, "\r\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(34);
                    __builder3.AddAttribute(35, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                           nameof(Master_Org.Id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "HeaderText", "Id");
                    __builder3.AddAttribute(37, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                                          false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "IsPrimaryKey", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                                                               true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\r\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(40);
                    __builder3.AddAttribute(41, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                           nameof(Master_Org.Org)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "HeaderText", "Name");
                    __builder3.AddAttribute(43, "Width", "100");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\r\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(45);
                    __builder3.AddAttribute(46, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                           nameof(Master_Org.Org_Name)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(47, "HeaderText", "Full Name");
                    __builder3.AddAttribute(48, "Width", "200");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n                ");
            }
            );
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 27 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "col-4");
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.AddMarkupContent(57, "<h5>Department</h5>\r\n");
#nullable restore
#line 31 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
             if (Master_Deps == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "                ");
            __builder.AddMarkupContent(59, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 34 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "                ");
            __Blazor.PrOnWeb.Pages.MasterDataConfig.TypeInference.CreateSfGrid_1(__builder, 61, 62, 
#nullable restore
#line 37 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                     Master_Deps

#line default
#line hidden
#nullable disable
            , 63, 
#nullable restore
#line 37 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                 true

#line default
#line hidden
#nullable disable
            , 64, "500", 65, 
#nullable restore
#line 37 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                                              new List<string>() { "Add", "Edit", "Update", "Cancel" }

#line default
#line hidden
#nullable disable
            , 66, 
#nullable restore
#line 37 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                                                                                                                      true

#line default
#line hidden
#nullable disable
            , 67, (__builder2) => {
                __builder2.AddMarkupContent(68, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEditSettings>(69);
                __builder2.AddAttribute(70, "AllowAdding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "AllowDeleting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "AllowEditing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.EditMode>(
#nullable restore
#line 38 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                                                        EditMode.Dialog

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEvents<Master_Dep>>(75);
                __builder2.AddAttribute(76, "OnActionComplete", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Grids.ActionEventArgs<Master_Dep>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Grids.ActionEventArgs<Master_Dep>>(this, 
#nullable restore
#line 39 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                  ActionCompleteDep

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(77, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(78);
                __builder2.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(80, "\r\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(81);
                    __builder3.AddAttribute(82, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                           nameof(Master_Dep.Id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(83, "HeaderText", "Id");
                    __builder3.AddAttribute(84, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                                          false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(85, "IsPrimaryKey", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                                                               true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(86, "\r\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(87);
                    __builder3.AddAttribute(88, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                           nameof(Master_Dep.Dep)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(89, "HeaderText", "Name");
                    __builder3.AddAttribute(90, "Width", "100");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(91, "\r\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(92);
                    __builder3.AddAttribute(93, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                           nameof(Master_Dep.Dep_Name)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(94, "HeaderText", "Full Name");
                    __builder3.AddAttribute(95, "Width", "200");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(96, "\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(97, "\r\n                ");
            }
            );
            __builder.AddMarkupContent(98, "\r\n");
#nullable restore
#line 46 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(99, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n        ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "col-4");
            __builder.AddMarkupContent(103, "\r\n            ");
            __builder.AddMarkupContent(104, "<h5>Section</h5>\r\n");
#nullable restore
#line 50 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
             if (Master_Secs == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(105, "                ");
            __builder.AddMarkupContent(106, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 53 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(107, "                ");
            __Blazor.PrOnWeb.Pages.MasterDataConfig.TypeInference.CreateSfGrid_2(__builder, 108, 109, 
#nullable restore
#line 56 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                     Master_Secs

#line default
#line hidden
#nullable disable
            , 110, 
#nullable restore
#line 56 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                 true

#line default
#line hidden
#nullable disable
            , 111, "500", 112, 
#nullable restore
#line 56 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                                              new List<string>() { "Add", "Edit", "Update", "Cancel" }

#line default
#line hidden
#nullable disable
            , 113, 
#nullable restore
#line 56 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                                                                                                                      true

#line default
#line hidden
#nullable disable
            , 114, (__builder2) => {
                __builder2.AddMarkupContent(115, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEditSettings>(116);
                __builder2.AddAttribute(117, "AllowAdding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 57 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(118, "AllowDeleting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 57 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(119, "AllowEditing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 57 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(120, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.EditMode>(
#nullable restore
#line 57 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                                                        EditMode.Dialog

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(121, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEvents<Master_Sec>>(122);
                __builder2.AddAttribute(123, "OnActionComplete", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Grids.ActionEventArgs<Master_Sec>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Grids.ActionEventArgs<Master_Sec>>(this, 
#nullable restore
#line 58 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                  ActionCompleteSec

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(124, "\r\n                    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(125);
                __builder2.AddAttribute(126, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(127, "\r\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(128);
                    __builder3.AddAttribute(129, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 60 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                           nameof(Master_Sec.Id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(130, "HeaderText", "Id");
                    __builder3.AddAttribute(131, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 60 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                                          false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(132, "IsPrimaryKey", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 60 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                                                                                               true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(133, "\r\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(134);
                    __builder3.AddAttribute(135, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 61 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                           nameof(Master_Sec.Sec)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(136, "HeaderText", "Name");
                    __builder3.AddAttribute(137, "Width", "100");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(138, "\r\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(139);
                    __builder3.AddAttribute(140, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
                                           nameof(Master_Sec.Sec_Name)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(141, "HeaderText", "Full Name");
                    __builder3.AddAttribute(142, "Width", "200");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(143, "\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(144, "\r\n                ");
            }
            );
            __builder.AddMarkupContent(145, "\r\n");
#nullable restore
#line 65 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(146, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\MasterDataConfig.razor"
       
    List<Master_Org> Master_Orgs;
    List<Master_Dep> Master_Deps;
    List<Master_Sec> Master_Secs;
    List<MasterDimension> MasterDimensions;

    protected override async Task OnInitializedAsync()
    {
        Master_Orgs = await prDataService.GetMasterOrgsAsync();
        Master_Deps = await prDataService.GetMasterDepsAsync();
        Master_Secs = await prDataService.GetMasterSecsAsync();
    }

    public async Task ActionComplete(ActionEventArgs<Master_Org> args)
    {
        if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
        {
            if (args.Data.Org != null)
            {
                await prDataService.UpdateMasterOrgsAsync(args.Data);
            }
        }
    }

    public async Task ActionCompleteDep(ActionEventArgs<Master_Dep> args)
    {
        if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
        {
            if (args.Data.Dep != null)
            {
                await prDataService.UpdateMasterDepsAsync(args.Data);
            }
        }
    }

    public async Task ActionCompleteSec(ActionEventArgs<Master_Sec> args)
    {
        if (args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
        {
            if (args.Data.Sec != null)
            {
                await prDataService.UpdateMasterSecsAsync(args.Data);
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrDataService prDataService { get; set; }
    }
}
namespace __Blazor.PrOnWeb.Pages.MasterDataConfig
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "AllowResizing", __arg1);
        __builder.AddAttribute(__seq2, "Width", __arg2);
        __builder.AddAttribute(__seq3, "Toolbar", __arg3);
        __builder.AddAttribute(__seq4, "AllowPaging", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateSfGrid_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "AllowResizing", __arg1);
        __builder.AddAttribute(__seq2, "Width", __arg2);
        __builder.AddAttribute(__seq3, "Toolbar", __arg3);
        __builder.AddAttribute(__seq4, "AllowPaging", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateSfGrid_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "AllowResizing", __arg1);
        __builder.AddAttribute(__seq2, "Width", __arg2);
        __builder.AddAttribute(__seq3, "Toolbar", __arg3);
        __builder.AddAttribute(__seq4, "AllowPaging", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

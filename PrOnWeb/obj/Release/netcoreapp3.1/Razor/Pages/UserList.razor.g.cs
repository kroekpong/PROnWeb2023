#pragma checksum "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\UserList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ae7e410fbb8e704a74ffb9ebf1c0d2884ede664"
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
#line 3 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\UserList.razor"
using PrOnWeb.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/UserList")]
    public partial class UserList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>User List</h3>\r\n");
#nullable restore
#line 8 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\UserList.razor"
 if (userWfAuthoTable == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 11 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\UserList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __Blazor.PrOnWeb.Pages.UserList.TypeInference.CreateSfGrid_0(__builder, 3, 4, 
#nullable restore
#line 14 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\UserList.razor"
                     userWfAuthoTable

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 14 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\UserList.razor"
                                                    true

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 14 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\UserList.razor"
                                                                          true

#line default
#line hidden
#nullable disable
            , 7, 
#nullable restore
#line 14 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\UserList.razor"
                                                                                               true

#line default
#line hidden
#nullable disable
            , 8, 
#nullable restore
#line 14 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\UserList.razor"
                                                                                                                    false

#line default
#line hidden
#nullable disable
            , 9, (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridGroupSettings>(11);
                __builder2.AddAttribute(12, "Columns", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 15 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\UserList.razor"
                                 GroupedColumns

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(14);
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(16, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(17);
                    __builder3.AddAttribute(18, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\UserList.razor"
                           nameof(vWorkflowAutho.Id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "HeaderText", "Name");
                    __builder3.AddAttribute(20, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 17 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\UserList.razor"
                                                                                  TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "Width", "350");
                    __builder3.AddAttribute(22, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(23, "\r\n");
#nullable restore
#line 19 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\UserList.razor"
                  
                    var userWfAuthoTable = (context as vWorkflowAutho);

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(24, "                    ");
                        __builder4.OpenElement(25, "div");
                        __builder4.OpenElement(26, "a");
                        __builder4.AddAttribute(27, "href", "#");
                        __builder4.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\UserList.razor"
                                                 () => Navigate(userWfAuthoTable)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(29, 
#nullable restore
#line 21 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\UserList.razor"
                                                                                     userWfAuthoTable.UserName

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(30, "\r\n");
                        __builder4.AddContent(31, "            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(33);
                    __builder3.AddAttribute(34, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\UserList.razor"
                           nameof(vWorkflowAutho.Email)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "HeaderText", "Email");
                    __builder3.AddAttribute(36, "Width", "300");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(38);
                    __builder3.AddAttribute(39, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\UserList.razor"
                           nameof(vWorkflowAutho.Org)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "HeaderText", "Org.");
                    __builder3.AddAttribute(41, "Width", "120");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(43);
                    __builder3.AddAttribute(44, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\UserList.razor"
                           nameof(vWorkflowAutho.Dep)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(45, "HeaderText", "Dept.");
                    __builder3.AddAttribute(46, "Width", "120");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(48);
                    __builder3.AddAttribute(49, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\UserList.razor"
                           nameof(vWorkflowAutho.Sec)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(50, "HeaderText", "Sec.");
                    __builder3.AddAttribute(51, "Width", "120");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n");
            }
            );
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 31 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\UserList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "D:\WORK\2019\PH\PR Online\Source Code\PrOnWeb\Pages\UserList.razor"
       
    public string[] GroupedColumns = new string[] { "UserName"};
    List<string> nameList = new List<string>();
    List<vWorkflowAutho> userWfAuthoTable;
    protected override async Task OnInitializedAsync()
    {
        userWfAuthoTable = await prDataService.GetVWorkflowAuthosAsync();
        List<UserTable> userTables = await prDataService.GetUserTablesAsync();
        foreach (UserTable user in userTables)
        {
            nameList.Add(user.UserName);
        }
        GroupedColumns = nameList.ToArray();
    }

    private void Navigate(vWorkflowAutho userTable)
    {
        navigationManager.NavigateTo($"UserProfile/{userTable.User_Id}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrDataService prDataService { get; set; }
    }
}
namespace __Blazor.PrOnWeb.Pages.UserList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "AllowPaging", __arg1);
        __builder.AddAttribute(__seq2, "AllowFiltering", __arg2);
        __builder.AddAttribute(__seq3, "AllowResizing", __arg3);
        __builder.AddAttribute(__seq4, "AllowGrouping", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

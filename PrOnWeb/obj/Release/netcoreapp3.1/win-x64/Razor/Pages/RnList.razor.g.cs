#pragma checksum "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RnList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8de151e3ad2e9a4f860e93766296c059c2b9c3b5"
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
#line 2 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RnList.razor"
using PrOnWeb.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RnList.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/rnlist")]
    public partial class RnList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RnList.razor"
 if (returningNotes == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 10 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RnList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<h3>Return Note List</h3>\r\n    ");
            __Blazor.PrOnWeb.Pages.RnList.TypeInference.CreateSfGrid_0(__builder, 2, 3, 
#nullable restore
#line 14 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RnList.razor"
                         returningNotes

#line default
#line hidden
#nullable disable
            , 4, 
#nullable restore
#line 14 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RnList.razor"
                                                      true

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 14 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RnList.razor"
                                                                            true

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 14 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RnList.razor"
                                                                                                 true

#line default
#line hidden
#nullable disable
            , 7, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(8);
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(10);
                    __builder3.AddAttribute(11, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RnList.razor"
                               nameof(ReturningNote.Pr_Id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "HeaderText", "");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(13, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(14);
                    __builder3.AddAttribute(15, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RnList.razor"
                               nameof(ReturningNote.Rn_Type)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "HeaderText", "Type");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(17, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(18);
                    __builder3.AddAttribute(19, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RnList.razor"
                               nameof(ReturningNote.Rn_Description)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "HeaderText", "Description");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 21 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RnList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\RnList.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    [CascadingParameter]
    private Task<AuthenticationState> _authState { get; set; }
    private AuthenticationState authState;
    ClaimsPrincipal CurrentUser = new ClaimsPrincipal();

    List<ReturningNote> returningNotes;
    int myUserId;

    protected override async Task OnInitializedAsync()
    {
        authState = await _authState;
        CurrentUser = (await _authState).User;

        if (CurrentUser.Identity.IsAuthenticated)
        {
            var myUserName = CurrentUser.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name).Value;
            UserTable userTable = await prDataService.GetUserTableFromUseNameAsync(myUserName);
            myUserId = userTable.Pr_User_Id;

            //fullName = userTable.UserName;

            returningNotes = await prDataService.GetRnList();

        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrDataService prDataService { get; set; }
    }
}
namespace __Blazor.PrOnWeb.Pages.RnList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "AllowPaging", __arg1);
        __builder.AddAttribute(__seq2, "AllowFiltering", __arg2);
        __builder.AddAttribute(__seq3, "AllowResizing", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

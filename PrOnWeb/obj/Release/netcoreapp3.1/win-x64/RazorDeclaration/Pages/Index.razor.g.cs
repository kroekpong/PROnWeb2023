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
#line 2 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Index.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Index.razor"
using System.Security.Principal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Index.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Index.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Index.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Index.razor"
       
    public string CurrenetUserName { get; set; } // should be replace by Claims

    [CascadingParameter]
    private Task<AuthenticationState> _authState { get; set; }
    ClaimsPrincipal CurrentUser = new ClaimsPrincipal();

    private AuthenticationState authState;

    private string FullName;
    private string user;
    public IList<string> CurrentRoles;

    protected override async Task OnInitializedAsync()
    {
        //user = contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

        authState = await _authState;
        CurrentUser = (await _authState).User;

        if (CurrentUser.Identity.IsAuthenticated)
        {
            var userName = WindowsIdentity.GetCurrent().Name.Split('\\').Last();
            // check ว่า user นี้ มีสิทธิ์ใช้ Pr Web App หรือไม่
            //int prUserId = Int16.Parse(CurrentUser.Claims.FirstOrDefault(c => c.Type == "PrUserId").Value);
            UserTable userTable = await prDataService.GetUserTableFromUseNameAsync(userName);
            if (userTable == null)
            {
                FullName = "No Permission";
            }
            else
            {
                FullName = userTable.FullName;

                var identity = CurrentUser.Identity as ClaimsIdentity;
                var existingClaim = identity.FindFirst("PrUserId");
                if (existingClaim != null)
                    identity.RemoveClaim(existingClaim);
                identity.AddClaim(new Claim("PrUserId", userTable.Pr_User_Id.ToString()));

                // Add role(s) to claim Type
                if (!CurrentUser.HasClaim(c => c.Type == ClaimTypes.Role))
                {
                    ClaimsIdentity id = new ClaimsIdentity();
                    id.AddClaim(new Claim(ClaimTypes.Role, "Users"));
                    id.AddClaim(new Claim(ClaimTypes.Role, "Administrators"));
                    CurrentUser.AddIdentity(id);
                }
            }

            //get ClaimIdentity
            var roles = ((ClaimsIdentity)CurrentUser.Identity).Claims
.Where(c => c.Type == ClaimTypes.Role)
.Select(c => c.Value);

            if (CurrentUser.IsInRole("Users"))
            {
                var x1 = "Yes";
            }

            //foreach (var claim in authState.User.Claims)
            //{
            //    Console.WriteLine(claim.Type);
            //    Console.WriteLine(claim.Value);
            //}
        }


    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Http.IHttpContextAccessor contextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PrOnWeb.Services.PrDataService prDataService { get; set; }
    }
}
#pragma warning restore 1591

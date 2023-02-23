#pragma checksum "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "871571c0a71610f90210553caf42706eaf1a63bd"
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
#line 2 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/administration")]
    public partial class Administration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Administration</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 11 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
         if (@context.User.IsInRole(ADMINISTRATION_ROLE))
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(3, "table");
                __builder2.AddAttribute(4, "class", "table");
                __builder2.AddMarkupContent(5, "<thead><tr><th>Id</th>\r\n                        <th>User Name</th>\r\n                        <th>Email</th></tr></thead>\r\n                ");
                __builder2.OpenElement(6, "tbody");
#nullable restore
#line 22 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                     foreach (var user in ColUsers)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(7, "tr");
                __builder2.OpenElement(8, "td");
                __builder2.AddContent(9, 
#nullable restore
#line 25 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                 user.Id.Substring(0, 5)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(10, " ...");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n                            ");
                __builder2.OpenElement(12, "td");
                __builder2.AddContent(13, 
#nullable restore
#line 26 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                 user.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n                            ");
                __builder2.OpenElement(15, "td");
                __builder2.AddContent(16, 
#nullable restore
#line 27 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                 user.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n                            ");
                __builder2.OpenElement(18, "td");
                __builder2.OpenElement(19, "button");
                __builder2.AddAttribute(20, "class", "btn btn-primary");
                __builder2.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                                  (() => EditUser(user))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(22, "\r\n                                    Edit\r\n                                ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 36 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 40 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
             if (ShowPopup)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "modal");
                __builder2.AddAttribute(25, "tabindex", "-1");
                __builder2.AddAttribute(26, "style", "display:block");
                __builder2.AddAttribute(27, "role", "dialog");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "modal-dialog");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "modal-content");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "modal-header");
                __builder2.AddMarkupContent(34, "<h3 class=\"modal-title\">Edit User</h3>\r\n                                \r\n                                ");
                __builder2.OpenElement(35, "button");
                __builder2.AddAttribute(36, "type", "button");
                __builder2.AddAttribute(37, "class", "close");
                __builder2.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                                  ClosePopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(39, "<span aria-hidden=\"true\">X</span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                            \r\n                            ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "modal-body");
#nullable restore
#line 57 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                 if (objUser.Id != "")
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(43, "p");
                __builder2.AddContent(44, 
#nullable restore
#line 59 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                        objUser.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 60 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                 if (objUser.Id != "")
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(45, "p");
                __builder2.AddContent(46, 
#nullable restore
#line 64 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                        objUser.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 65 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(47, "input");
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "type", "text");
                __builder2.AddAttribute(50, "placeholder", "UserName");
                __builder2.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                                  objUser.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objUser.UserName = __value, objUser.UserName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
#nullable restore
#line 71 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(53, "input");
                __builder2.AddAttribute(54, "class", "form-control");
                __builder2.AddAttribute(55, "type", "text");
                __builder2.AddAttribute(56, "placeholder", "Email");
                __builder2.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 74 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                              objUser.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objUser.Email = __value, objUser.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                                ");
                __builder2.OpenElement(60, "input");
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "type", "password");
                __builder2.AddAttribute(63, "placeholder", "Password");
                __builder2.AddAttribute(64, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 77 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                              objUser.PasswordHash

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objUser.PasswordHash = __value, objUser.PasswordHash));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                                ");
                __builder2.OpenElement(67, "select");
                __builder2.AddAttribute(68, "class", "form-control");
                __builder2.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 79 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                                CurrentUserRole

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CurrentUserRole = __value, CurrentUserRole));
                __builder2.SetUpdatesAttributeName("value");
#nullable restore
#line 80 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                     foreach (var option in Options)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(71, "option");
                __builder2.AddAttribute(72, "value", 
#nullable restore
#line 82 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                                        option

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(73, 
#nullable restore
#line 83 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                             option

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 85 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                                <br><br>\r\n                                \r\n                                ");
                __builder2.OpenElement(75, "button");
                __builder2.AddAttribute(76, "class", "btn btn-primary");
                __builder2.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 90 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                                  SaveUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(78, "\r\n                                    Save\r\n                                ");
                __builder2.CloseElement();
#nullable restore
#line 94 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                 if (objUser.Id != "")
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(79, "button");
                __builder2.AddAttribute(80, "class", "btn btn-danger");
                __builder2.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 98 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                                      DeleteUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(82, "\r\n                                        Delete\r\n                                    ");
                __builder2.CloseElement();
#nullable restore
#line 101 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(83, "<br>\r\n                                ");
                __builder2.OpenElement(84, "span");
                __builder2.AddAttribute(85, "style", "color:red");
                __builder2.AddContent(86, 
#nullable restore
#line 103 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                                         strError

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 108 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(87, "button");
                __builder2.AddAttribute(88, "class", "btn btn-success");
                __builder2.AddAttribute(89, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 109 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                                      AddNewUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(90, "Add User");
                __builder2.CloseElement();
#nullable restore
#line 110 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(91, "p");
                __builder2.AddContent(92, "You\'re not signed in as a user in ");
                __builder2.AddContent(93, 
#nullable restore
#line 113 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
                                                  ADMINISTRATION_ROLE

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(94, ".");
                __builder2.CloseElement();
#nullable restore
#line 114 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(95, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(96, "<p>You\'re not loggged in.</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 120 "C:\Users\bunlue\source\repos\PrOnWeb\Pages\Administration.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    string ADMINISTRATION_ROLE = "Administrators";
    System.Security.Claims.ClaimsPrincipal CurrentUser;

    // Property used to add or edit the currently selected user
    ApplicationUser objUser = new ApplicationUser();
    // Tracks the selected role for the currently selected user
    string CurrentUserRole { get; set; } = "Users";
    // Collection to display the existing users
    List<ApplicationUser> ColUsers = new List<ApplicationUser>();
    // Options to display in the roles dropdown when editing a user
    List<string> Options = new List<string>() { "Accountings","SMs","DMs", "Users", "Administrators" };
    // To hold any possible errors
    string strError = "";
    // To enable showing the Popup
    bool ShowPopup = false;

    protected override async Task OnInitializedAsync()
    {
        // ensure there is a ADMINISTRATION_ROLE
 
        // Ensure a user named Admin@BlazorHelpWebsite.com is an Administrator
        var user = await _UserManager.FindByNameAsync("Admin@BlazorHelpWebsite.com");
        if (user != null)
        {
            // Is Admin@BlazorHelpWebsite.com in administrator role?
            var UserResult = await _UserManager.IsInRoleAsync(user, ADMINISTRATION_ROLE);
            if (!UserResult)
            {
                // Put admin in Administrator role
                await _UserManager.AddToRoleAsync(user, ADMINISTRATION_ROLE);
            }
        }
        // Get the current logged in user
        CurrentUser = (await authenticationStateTask).User;
        GetUsers();

    }
    void AddNewUser()
    {
        // Make new user
        objUser = new ApplicationUser();
        objUser.PasswordHash = "*****";
        // Set Id to blank so we know it is a new record
        objUser.Id = "";
        // Open the Popup
        ShowPopup = true;

    }
    async Task SaveUser()
    {
        try
        {
            // Is this an existing user?
            if (objUser.Id != "")
            {
                // Get the user
                var user = await _UserManager.FindByIdAsync(objUser.Id);
                // Update Email
                user.Email = objUser.Email;
                // Update the user
                await _UserManager.UpdateAsync(user);
                // Only update password if the current value
                // is not the default value
                if (objUser.PasswordHash != "*****")
                {
                    var resetToken =
                        await _UserManager.GeneratePasswordResetTokenAsync(user);
                    var passworduser =
                        await _UserManager.ResetPasswordAsync(
                            user,
                            resetToken,
                            objUser.PasswordHash);
                    if (!passworduser.Succeeded)
                    {
                        if (passworduser.Errors.FirstOrDefault() != null)
                        {
                            strError =
                                passworduser
                                .Errors
                                .FirstOrDefault()
                                .Description;
                        }
                        else
                        {
                            strError = "Pasword error";
                        }
                        // Keep the popup opened
                        return;
                    }
                }
                // Handle Roles
                // Is user in administrator role?
                var UserResult =
                    await _UserManager.IsInRoleAsync(user, ADMINISTRATION_ROLE);
                // Is Administrator role selected
                // but user is not an Administrator?
                if (
                    (CurrentUserRole == ADMINISTRATION_ROLE) & (!UserResult))
                {
                    // Put admin in Administrator role
                    await _UserManager.AddToRoleAsync(user, ADMINISTRATION_ROLE);
                }
                else
                {
                    // Is Administrator role not selected
                    // but user is an Administrator?
                    //if ((CurrentUserRole != ADMINISTRATION_ROLE)
                    //    &
                    //    (UserResult))
                    //{
                    //    // Remove user from Administrator role
                    //    await _UserManager
                    //        .RemoveFromRoleAsync(user, ADMINISTRATION_ROLE);
                    //}
                    await _UserManager.AddToRoleAsync(user, CurrentUserRole);
                }
            }
            else
            {
                // Insert new user
                var NewUser =
                    new ApplicationUser
                    {
                        UserName = objUser.UserName,
                        Email = objUser.Email
                    };
                var CreateResult =
                    await _UserManager
                    .CreateAsync(NewUser, objUser.PasswordHash);
                if (!CreateResult.Succeeded)
                {
                    if (CreateResult
                        .Errors
                        .FirstOrDefault() != null)
                    {
                        strError =
                            CreateResult
                            .Errors
                            .FirstOrDefault()
                            .Description;
                    }
                    else
                    {
                        strError = "Create error";
                    }
                    // Keep the popup opened
                    return;
                }
                else
                {
                    // Handle Roles
                    if (CurrentUserRole == ADMINISTRATION_ROLE)
                    {
                        // Put admin in Administrator role
                        await _UserManager
                            .AddToRoleAsync(NewUser, ADMINISTRATION_ROLE);
                    }
                }
            }
            // Close the Popup
            ShowPopup = false;
            // Refresh Users
            GetUsers();
        }
        catch (Exception ex)
        {
            strError = ex.GetBaseException().Message;
        }

    }
    async Task EditUser(ApplicationUser _IdentityUser)
    {
        // Set the selected user
        // as the current user
        objUser = _IdentityUser;
        // Get the user
        IList<string> userRoles;
        var user = await _UserManager.FindByIdAsync(objUser.Id);
        if (user != null)
        {
            // Is user in administrator role?
            var UserResult = await _UserManager.IsInRoleAsync(user, ADMINISTRATION_ROLE);
            if (UserResult)
            {
                CurrentUserRole = ADMINISTRATION_ROLE;
            }
            else
            {
                userRoles = await _UserManager.GetRolesAsync(user);
                CurrentUserRole = userRoles.FirstOrDefault();
            }
        }
        // Open the Popup
        ShowPopup = true;
    }
    async Task DeleteUser()
    {
        // Close the Popup
        ShowPopup = false;
        // Get the user
        var user = await _UserManager.FindByIdAsync(objUser.Id);
        if (user != null)
        {
            // Delete the user
            await _UserManager.DeleteAsync(user);
        }
        // Refresh Users
        GetUsers();
    }
    void ClosePopup()
    {
        // Close the Popup
        ShowPopup = false;
    }
    public void GetUsers()
    {
        // clear any error messages
        strError = "";
        // Collection to hold users
        ColUsers = new List<ApplicationUser>();
        // get users from _UserManager
        var user = _UserManager.Users.Select(x => new ApplicationUser
        {
            Id = x.Id,
            UserName = x.UserName,
            Email= x.Email,
            PasswordHash = "*****"

        });
        foreach (var item in user)
        {
            ColUsers.Add(item);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RoleManager<IdentityRole> _RoleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> _UserManager { get; set; }
    }
}
#pragma warning restore 1591

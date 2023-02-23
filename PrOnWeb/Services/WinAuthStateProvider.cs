using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PrOnWeb.Services
{
    // ใช้เพื่อการ ดึง authorization จาก Windows AD เข้ามา
    public class WinAuthStateProvider : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //Getting logged in windows user name
            var user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            var WindowsAuth = new ClaimsIdentity(new List<Claim>() {
                new Claim(ClaimTypes.Name,user.Split('\\')[1]),
            new Claim("PrUserId", "x")}, "windows");


            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(WindowsAuth)));

            //var UserRole = UserManager.GetRolesAsync(user);
            //claims.AddClaim(new Claim("Role", UserRole.Result.FirstOrDefault().ToString()));

            //Logic for fetching role from DB — Here you can get other details abou user from DB also
            //string role = UserService.retRole(user.Split("\\")[1]);
            ////Generating new Authentication state with claims if user have any role
            //if (role != "" && role != null)
            //{
            //var WindowsAuth = new ClaimsIdentity(new List<Claim>() {
            //    new Claim(ClaimTypes.Name,user.Split('\\')[1]),
            //    new Claim(ClaimTypes.Role,role)}, "windows");
            //return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(WindowsAuth)));
            //}
            //else
            //{
            //    var anonymous = new ClaimsIdentity();
            //    return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonymous)));
            //}
        }
    }
}

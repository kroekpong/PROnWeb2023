using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using PrOnWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PrOnWeb.Services
{
    public class ClaimService : UserClaimsPrincipalFactory<ApplicationUser, IdentityRole>
    {
        public ClaimService(UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IOptions<IdentityOptions> optionAccessor)
            : base(userManager, roleManager, optionAccessor)
        {

        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
        {
            var claims = await base.GenerateClaimsAsync(user);
            claims.AddClaim(new Claim("PrUserId", user.PrUserId));
            claims.AddClaim(new Claim("FullName", user.FullName));

            //Add role to Claim
            //var UserRole = UserManager.GetRolesAsync(user);
            //claims.AddClaim(new Claim("Role", UserRole.Result.FirstOrDefault().ToString()));
            return claims;
        }

        public static Claim CreateClaim(string type, string value)
        {
            return new Claim(type, value, ClaimValueTypes.String);
        }
    }

}

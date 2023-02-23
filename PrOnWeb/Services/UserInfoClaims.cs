using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PrOnWeb.Services
{
    public class UserInfoClaims : IClaimsTransformation
    {
        public Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        {
            if (!principal.HasClaim(c => c.Type == ClaimTypes.Name))
            {
                ClaimsIdentity id = new ClaimsIdentity();
                id.AddClaim(new Claim(ClaimTypes.Name, "Canada"));
                principal.AddIdentity(id);
            }
            return Task.FromResult(principal);
        }
    }
}

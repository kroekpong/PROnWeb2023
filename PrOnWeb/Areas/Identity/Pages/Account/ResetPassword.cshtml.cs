using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using PrOnWeb.Data;
using PrOnWeb.Services;
using VendorPortalWeb.Helpers;

namespace PrOnWeb.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ResetPasswordModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AuthenService _authenService;
        public ResetPasswordModel(UserManager<ApplicationUser> userManager, AuthenService authenService)
        {
            _userManager = userManager;
            _authenService = authenService;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            //[Required]
            //[EmailAddress]
            //public string Email { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "User Name")]
            public string UserName { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            public string Code { get; set; }
        }

        public IActionResult OnGet(string code = null,string uname="")
        {
            if (code == null)
            {
                return BadRequest("A code must be supplied for password reset.");
            }
            else
            {
                Input = new InputModel
                {
                    Code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code)),
                    UserName = uname
                };
                return Page();
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //var user = await _userManager.FindByEmailAsync(Input.Email);
            var user = await _userManager.FindByNameAsync(Input.UserName);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                ModelState.AddModelError(string.Empty, "Email user does not existed !");
                return Page();
                //return RedirectToPage("./ResetPasswordConfirmation");
            }

            var hPassword = AuthHelper.GetMD5HashData(Input.Password);
            var passList = await _authenService.GetPasswordHistoryAsync(user.Id);
            if (passList.Contains(hPassword))
            {
                ModelState.AddModelError(string.Empty, "Can not input Password repeatedly for 5 times ! ");
                return Page();
            }


            var result = await _userManager.ResetPasswordAsync(user, Input.Code, Input.Password);
            if (result.Succeeded)
            {
                user.LastPasswordChangedDate = DateTime.Now;
                await _userManager.UpdateAsync(user);

                // Update hISTORY pASSWORD wHEN Sucess 
                await _authenService.UpdatePasswordHistoryAsync(user.Id, hPassword);

                return RedirectToPage("./ResetPasswordConfirmation");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return Page();
                //await _authenService.UpdatePasswordHistoryAsync(user.Id, hPassword);
            }

        }
    }
}

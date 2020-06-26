using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using AcademicApplication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity.UI.Services;
using AcademicApplication.Services;

namespace AcademicApplication.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginWith2faModel : PageModel
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ILogger<LoginWith2faModel> _logger;
        private readonly ISmsSender _smsSender;
        private readonly UserManager<AppUser> _userManager;
        private readonly IEmailSender _emailSender;

        public LoginWith2faModel(SignInManager<AppUser> signInManager, 
            ILogger<LoginWith2faModel> logger,
            ISmsSender smsSender,
            UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _logger = logger;
            _smsSender = smsSender;
            _userManager = userManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            [StringLength(7, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Text)]
            [Display(Name = "Authenticator code")]
            public string TwoFactorCode { get; set; }

            [Display(Name = "Remember this machine")]
            public bool RememberMachine { get; set; }
        }

        public async Task<IActionResult> OnGetAsync(bool rememberMe, string returnUrl = null)
        {

            var user = await _signInManager.GetTwoFactorAuthenticationUserAsync();
            // Ensure the user has gone through the username & password screen first
            //var user = await _signInManager.GetTwoFactorAuthenticationUserAsync();

            await  SendTwoFactorCode(_userManager.Options.Tokens.AuthenticatorTokenProvider, user);
         

            //string message = $"Code for two factor authentication is";
            //await _smsSender.SendSmsAsync(user.PhoneNumber, message);
            if (user == null)
            {
                throw new InvalidOperationException($"Unable to load two-factor authentication user.");
            }



            ReturnUrl = returnUrl;
            RememberMe = rememberMe;

            return Page();
        }

        public async Task<bool> SendTwoFactorCode(string provider,AppUser user)
        {
            var _user = _userManager.FindByIdAsync(user.Id).Result;
            if ( _user== null)
            {
                return false;
            }

          
            //var code = await _userManager.GenerateChangePhoneNumberTokenAsync(user, user.PhoneNumber);
            var code = await _userManager.GenerateTwoFactorTokenAsync(user, provider);

             //_userManager.NotifyTwoFactorTokenAsync(user.Id, provider, code);
            //var code = await _userManager.GenerateTwoFactorTokenAsync(user, provider);
            var message = "Your Two-Factor verification code is: " + code;

            //var token = await _userManager.GenerateTwoFactorTokenAsync(_user, provider);

            //string message = $"Code for two tttttttttttttt factor authentication is{token}";
            await _smsSender.SendSmsAsync(user.PhoneNumber, message);

            // See IdentityConfig.cs to plug in Email/SMS services to actually send the code
            return true;
        }

        public async Task<IActionResult> OnPostAsync(bool rememberMe, string returnUrl = null)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            returnUrl = returnUrl ?? Url.Content("~/");

            var user = await _signInManager.GetTwoFactorAuthenticationUserAsync();
            if (user == null)
            {
                throw new InvalidOperationException($"Unable to load two-factor authentication user.");
            }

            var authenticatorCode = Input.TwoFactorCode.Replace(" ", string.Empty).Replace("-", string.Empty);
            

            var result = await _signInManager.TwoFactorAuthenticatorSignInAsync(authenticatorCode, rememberMe, Input.RememberMachine);

            if (result.Succeeded)
            {
                _logger.LogInformation("User with ID '{UserId}' logged in with 2fa.", user.Id);
                return LocalRedirect(returnUrl);
            }
            else if (result.IsLockedOut)
            {
                _logger.LogWarning("User with ID '{UserId}' account locked out.", user.Id);
                return RedirectToPage("./Lockout");
            }
            else
            {
                _logger.LogWarning("Invalid authenticator code entered for user with ID '{UserId}'.", user.Id);
                ModelState.AddModelError(string.Empty, "Invalid authenticator code.");
                return Page();
            }
        }

    }
}

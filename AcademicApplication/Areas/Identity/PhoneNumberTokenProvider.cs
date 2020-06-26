using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AcademicApplication.Areas.Identity
{

    public class PhoneNumberTokenProvider<TUser> : TotpSecurityStampBasedTokenProvider<TUser> where TUser : class
    {
        public override async Task<bool> CanGenerateTwoFactorTokenAsync(UserManager<TUser> manager, TUser user)
        {
            if (manager == null)
            {
                throw new ArgumentNullException(nameof(manager));
            }
            var phoneNumber = await  manager.GetPhoneNumberAsync(user);
            return !string.IsNullOrWhiteSpace(phoneNumber) && await  manager.IsPhoneNumberConfirmedAsync(user);
        }

        public override async Task<string> GetUserModifierAsync(string purpose, UserManager<TUser> manager, TUser user)
        {
            if (manager == null)
            {
                throw new ArgumentNullException(nameof(manager));
            }
            var phoneNumber = await manager.GetPhoneNumberAsync(user);
            return "PhoneNumber:" + purpose + ":" + phoneNumber;
        }
    }
}

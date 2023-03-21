using IdentityDemo.Views.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;

namespace IdentityDemo.Models
{
    public class AccountService
    {
        UserManager<ApplicationUser> userManager;
        SignInManager<ApplicationUser> signInManager;
        RoleManager<IdentityRole> roleManager;

        public AccountService(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

    public async Task<string> TryRegisterAsync(RegisterVM viewModel)
        {
            var user = new ApplicationUser
            {
                UserName = viewModel.Username,
            };

            IdentityResult result = await userManager.CreateAsync(user, viewModel.Password);
            return result.Errors.FirstOrDefault()?.Description;

        }

        public async Task<bool> TryLoginAsync(LoginVM viewModel)
        {
            SignInResult result = await signInManager.PasswordSignInAsync(
         viewModel.Username,
         viewModel.Password,
         isPersistent: false,
         lockoutOnFailure: false);

            return result.Succeeded;

        }
		public async Task<bool> TryLogoutAsync(LoginVM viewModel)
		{
			SignInResult result = await signInManager.LogoutAsync()
			//SignInResult result = await signInManager.PasswordSignInAsync(
		 //viewModel.Username,
		 //viewModel.Password,
		 //isPersistent: false,
		 //lockoutOnFailure: false);

			return result.Succeeded;

		}
	}
}

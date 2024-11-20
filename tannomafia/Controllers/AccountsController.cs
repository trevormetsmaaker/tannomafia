using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using tannomafia.Models.Accounts;
using TannoMafia.Core.Domain;
using TannoMafia.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace tannomafia.Controllers
{
    public class AccountsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _SignManager;
        private readonly TannoMafiaContext _context;

        public AccountsController

            (UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> SignInManager,
            TannoMafiaContext context
            )
        {
            _userManager = userManager;
            _SignManager = SignInManager;
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> AddPassword()
        {
            var user = await _userManager.GetUserAsync(User);
            var result = await _userManager.HasPasswordAsync(user);
            if (userHasPassword)
            {
                RedirectToAction("ChangePassword");
            }
            return View();
        }   



        [HttpGet]
            public async Task<IActionResult> AddPassword(AddPasswordViewModel model)
            {
                if (ModelState.IsValid)
                {
                   var user  = await _userManager.GetUserAsync(User);
                   var result = await _userManager.AddPasswordAsync(user, model.NewPassword);
                   if (!result.Succeeded)
                   {
                     ModelState.AddModelError(string.Empty, error.Description);
                   }
                }  return View();
                await _signInManager.RefreshSignInAsync(User);
                return View("AddPasswordConfirmation");
            }
            Return view(model)


    }
}

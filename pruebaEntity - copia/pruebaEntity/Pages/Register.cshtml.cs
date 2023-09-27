using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pruebaEntity.Repository.Models;

namespace pruebaEntity.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> singManager;
        [BindProperty]
        public Userapp Model { get; set; }

        public RegisterModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> singManager)
        {
            this.userManager = userManager;
            this.singManager = singManager;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = new IdentityUser()
                {
                    UserName = Model.Email,
                    Email = Model.Email
                };
                IdentityResult result = await userManager.CreateAsync(user, Model.PasswordHash);
                if (result.Succeeded)
                {
                    await singManager.SignInAsync(user, false);
                    return RedirectToPage("Index");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return Page();
        }
    }
}

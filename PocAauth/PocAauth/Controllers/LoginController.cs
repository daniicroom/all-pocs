using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PocAauth.Data;
using PocAauth.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PocAauth.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<UserApp> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<UserApp> _signInManager;
        public LoginController(SignInManager<UserApp> signInManager,
            UserManager<UserApp> userManager,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }
        public async Task<IActionResult> Login(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                //var user = await _userManager.FindByEmailAsync(model.email);
                var user = await _userManager.FindByNameAsync(model.email);
                if (user != null)
                {
                    string otpCode = "2323";
                    //var otpCode = GenerateOneTimePassword();
                    _context.CreateOneTimePassword(user.Id, otpCode, 5);

                    // Aquí debes enviar el código OTP al usuario (por ejemplo, por correo electrónico o SMS).

                    return RedirectToAction("EnterOTP", new { userId = user.Id });
                }

                ModelState.AddModelError("", "Nombre de usuario incorrecto.");
            }

            return View(model);
        }

        public IActionResult EnterOTP(int userId)
        {
            OTPSignIn model = new OTPSignIn { UserAppId = userId };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EnterOTP(OTPSignIn model)
        {
            var otp = _context.GetOneTimePassword((int)model.UserAppId, model.Code);
            if (otp != null)
            {
                // El código OTP es válido, así que puedes permitir que el usuario inicie sesión.
                // También debes eliminar el código OTP de la tabla para evitar su reutilización.
                //_context.OTPSignIns.Remove(otp);
                var codes = _context.OTPSignIns.Where(x => x.Code == model.Code && x.IsDeleted == false && x.ExpirationTime>DateTime.Now).SingleOrDefault();
                codes.IsDeleted = true;
                _context.SaveChanges();
                //ExternalLogins = (awa_signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
                var user = await _userManager.FindByIdAsync(model.UserAppId.ToString());
                //await _signInManager.SignInAsync(user, false);
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.UserName)
                };
                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = false
                };
                ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                await _signInManager.SignInAsync(user, false);
                //HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal).Wait();
                //await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,new ClaimsPrincipal(identity),authProperties);
                //return RedirectToAction("Prueba", "Reenvio");
                string returnUrl = Url.Content("~/Prueba/Reenvio");
                return LocalRedirect(returnUrl);
            }

            ModelState.AddModelError("", "Código OTP inválido.");
            return View(model);
        }
        public string GenerateOneTimePassword()
        {
            var digits = "1234567890";
            var otp = new StringBuilder();
            var random = new Random();

            for (int i = 0; i < 6; i++)
            {
                otp.Append(digits[random.Next(0, digits.Length)]);
            }

            return otp.ToString();
        }
    }
}

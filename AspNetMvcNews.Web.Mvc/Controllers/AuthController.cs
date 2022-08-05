using AspNetMvcNews.Data;
using AspNetMvcNews.Data.Entity;
using AspNetMvcNews.Web.Mvc.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace aspnet_mvc_news.Controllers
{
    public class AuthController : Controller
    {
        private readonly AppDbContext Db;

        public AuthController(AppDbContext db)
        {
            Db = db;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var users = Db.Users.ToList();

                foreach (var item in users)
                {
                    if ((item.Email != model.EmailAdress || item.Name != model.Username) && model.Password == model.Password2)
                    {
                        var newUser = new User
                        {
                            Email = model.EmailAdress,
                            Name = model.Username,
                            Password = model.Password,
                        };
                        Db.Users.Add(newUser);
                        Db.SaveChanges();
                    }

                    else
                    {
                        
                        return View();
                    }
                }

            }

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string? returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = Db.Users.FirstOrDefault(e => e.Email == model.EmailAdress && e.Password == model.Password);
                if (user != null)
                {
                    var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.NameIdentifier, user.Name),
                        new Claim(ClaimTypes.Name,user.Name),
                        new Claim(ClaimTypes.Email,user.Email),
                    };

                    if (user.City != null)
                    {
                        claims.Add(new Claim(ClaimTypes.Country, user.City));
                    }

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var claimsPrinciple = new ClaimsPrincipal(claimsIdentity);

                    var properties = new AuthenticationProperties
                    {
                        IsPersistent = model.RememberMe,
                        ExpiresUtc = DateTime.UtcNow.AddDays(30),
                    };

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrinciple, properties);


                    return Redirect(returnUrl == null ? "/" : returnUrl);

                }

            }
            ModelState.AddModelError(string.Empty, "Email veya Şifreniz Hatalı");

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return Redirect("/");

        }


        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}

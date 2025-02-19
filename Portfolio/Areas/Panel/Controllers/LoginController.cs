using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using BusinessLayer.DTO;
using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace PortfolioPresentation.Areas.Panel.Controllers
{
    [Area("Panel")]
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly HttpClient _httpClient;

        public LoginController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<IActionResult> LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(UserLoginViewModel p)
        {
            var result = await _httpClient.PostAsJsonAsync("https://localhost:7137/api/ApplicationUser/login", p);

            if (!result.IsSuccessStatusCode)

            {
                if (ModelState.IsValid)
                    ModelState.AddModelError("", await result.Content.ReadAsStringAsync());

                return View();
            }
            else
            {
                var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, p.UserName)
            // Diğer claim'ler eklenebilir (roller, izinler vb.)
        };
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                // Kullanıcıyı oturum açtır
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
            }
            return View();
        }

        public async Task<IActionResult> Register(UserRegisterViewModel p)
        {
            if (ModelState.IsValid)
            {

                var result = await _httpClient.PostAsJsonAsync("https://localhost:7137/api/ApplicationUser/register", p);

                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Home");
                }
                return View(); // Buraya giriyor
            }

            return View();
        }

        public IActionResult LogOut()
        {
            return View();
        }
    }
}

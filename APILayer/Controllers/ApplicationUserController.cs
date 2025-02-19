using BusinessLayer.Abstract;
using BusinessLayer.DTO;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace APILayer.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : BaseController<ApplicationUser>
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public ApplicationUserController(IApplicationUserService genericService, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager) : base(genericService)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Add([FromBody] UserRegisterViewModel entity)
        {
            ApplicationUser user = new()
            {
                UserName = entity.UserName,
                Email = entity.Email,
                Name = entity.Name,
                ImageUrl = entity.ImageUrl
            };
            var result = await _userManager.CreateAsync(user, entity.Password);

            if (result.Succeeded)
                return Ok();
            else
                return BadRequest();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginViewModel entity)
        {



            var result = await _signInManager.PasswordSignInAsync(entity.UserName, entity.Password, true, false);

            if (result.Succeeded)
                return Ok();
            else
                return BadRequest("Kullanıcı Adı veya Şifre hatalı.");
        }
    }
}

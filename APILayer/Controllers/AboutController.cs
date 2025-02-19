using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : BaseController<About>
    {
        public AboutController(IAboutService genericService) : base(genericService)
        {
        }
    }
}

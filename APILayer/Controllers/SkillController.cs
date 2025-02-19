using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : BaseController<Skill>
    {
        public SkillController(ISkillService genericService) : base(genericService)
        {
        }
    }
}

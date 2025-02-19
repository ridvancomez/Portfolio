using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : BaseController<Contact>
    {
        public ContactController(IContactService genericService) : base(genericService)
        {
        }
    }
}

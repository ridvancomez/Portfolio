using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactMessageController : BaseController<ContactMessage>
    {
        public ContactMessageController(IContactMessageService service) : base(service)
        {
        }
    }
}

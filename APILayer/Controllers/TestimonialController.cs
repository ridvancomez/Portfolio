using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : BaseController<Testimonial>
    {
        public TestimonialController(ITestimonialService service) : base(service)
        {
        }
    }
}

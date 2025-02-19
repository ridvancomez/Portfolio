using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : BaseController<Comment>
    {
        public CommentController(ICommentService service) : base(service)
        {
        }
    }
}

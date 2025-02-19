using Microsoft.AspNetCore.Mvc;

namespace PortfolioPresentation.Controllers
{
    public class BlogController : Controller
    {
        [HttpGet]
        public IActionResult Index(int page = 1)
        {
            int pageSize = 10; 
            //id pagination için aldım
            return View();
        }

        [HttpGet]
        public IActionResult BlogPost(int id)
        {
            return View();
        }

    }
}

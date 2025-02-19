using Microsoft.AspNetCore.Mvc;

namespace PortfolioPresentation.ViewComponents
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

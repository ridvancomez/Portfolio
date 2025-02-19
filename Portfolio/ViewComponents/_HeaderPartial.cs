using Microsoft.AspNetCore.Mvc;

namespace PortfolioPresentation.ViewComponents
{
    public class _HeaderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

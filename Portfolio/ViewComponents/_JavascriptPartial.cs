using Microsoft.AspNetCore.Mvc;

namespace PortfolioPresentation.ViewComponents
{
    public class _JavascriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

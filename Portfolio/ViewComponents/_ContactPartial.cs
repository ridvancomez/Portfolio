using Microsoft.AspNetCore.Mvc;

namespace PortfolioPresentation.ViewComponents
{
    public class _ContactPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

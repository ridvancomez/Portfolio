using Microsoft.AspNetCore.Mvc;

namespace PortfolioPresentation.ViewComponents
{
    public class _PhotoswipePartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace PortfolioPresentation.ViewComponents
{
    public class _ExperiencePartial : ViewComponent
    {
        private readonly HttpClient _httpclient;
        public _ExperiencePartial(HttpClient httpClient)
        {
            _httpclient = httpClient;
        }
        public IViewComponentResult Invoke()
        {
            var response = _httpclient.GetStringAsync("https://localhost:7137/api/Experience");
            var apiData = JsonConvert.DeserializeObject<List<Experience>>(response.Result);
            return View(apiData);
        }
    }
}
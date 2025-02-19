using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace PortfolioPresentation.ViewComponents
{
    public class _AboutPartial : ViewComponent
    {
        private readonly HttpClient _httpClient;

        public _AboutPartial(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var respone = await _httpClient.GetStringAsync("https://localhost:7137/api/About");
            var apiData = JsonConvert.DeserializeObject<List<About>>(respone);

            return View(apiData);
        }
    }
}

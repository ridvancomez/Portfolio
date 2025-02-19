using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace PortfolioPresentation.ViewComponents
{
    public class _BlogPartial : ViewComponent
    {
        private readonly HttpClient _httpClient;

        public _BlogPartial(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await _httpClient.GetStringAsync("https://localhost:7137/api/Blog");

            var apiData = JsonConvert.DeserializeObject<List<Blog>>(response);

            return View(apiData);
        }
    }
}

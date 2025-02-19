using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace PortfolioPresentation.ViewComponents
{
    public class _FooterPartial : ViewComponent
    {
        private readonly HttpClient _httpClient;

        public _FooterPartial(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await _httpClient.GetStringAsync("https://localhost:7137/api/SocialMedia");
            var apiData = JsonConvert.DeserializeObject<List<SocialMedia>>(response);

            return View(apiData);
        }
    }
}

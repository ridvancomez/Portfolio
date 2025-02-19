using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace PortfolioPresentation.ViewComponents
{
    public class _TestimonialPartial : ViewComponent
    {
        private readonly HttpClient _httpClient;

        public _TestimonialPartial(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await _httpClient.GetStringAsync("https://localhost:7137/api/Testimonial");

            var apiData = JsonConvert.DeserializeObject<List<Testimonial>>(response);

            return View(apiData);
        }
    }
}

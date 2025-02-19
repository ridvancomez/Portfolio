using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace PortfolioPresentation.ViewComponents
{
    public class _FeaturePartial : ViewComponent
    {
        private readonly HttpClient _httpClient;

        public _FeaturePartial(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var responseFeature = await _httpClient.GetStringAsync("https://localhost:7137/api/Feature");
            var responseSocialMedia = await _httpClient.GetStringAsync("https://localhost:7137/api/SocialMedia");

            // Veriyi modelle birlikte View'a gönderme
            var apiDataFeature = JsonConvert.DeserializeObject<List<Feature>>(responseFeature);
            var apiDataSocialMedia = JsonConvert.DeserializeObject<List<SocialMedia>>(responseSocialMedia);

            ViewBag.SocialMedia = apiDataSocialMedia;

            // View'a model verisi gönderiliyor
            return View(apiDataFeature);
        }
    }
}

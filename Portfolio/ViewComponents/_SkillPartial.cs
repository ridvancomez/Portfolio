using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace PortfolioPresentation.ViewComponents
{
    public class _SkillPartial : ViewComponent
    {
        private readonly HttpClient _httpClient;

        public _SkillPartial(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var response = await _httpClient.GetStringAsync("https://localhost:7137/api/Skill");
            var apiData = JsonConvert.DeserializeObject<List<Skill>>(response);

            return View(apiData);
        }
    }
}

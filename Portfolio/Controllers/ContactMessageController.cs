using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioPresentation.Controllers
{
    public class ContactMessageController : Controller
    {
        HttpClient _httpClient;
        public ContactMessageController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public IActionResult SendMessage([FromBody] ContactMessage formData)
        {
            if (ModelState.IsValid)
            { 
            formData.MessageDate = DateTime.Now;
                formData.IsRead = false;
                _httpClient.PostAsJsonAsync("https://localhost:7137/api/ContactMessage", formData);

                return Json(new { success = true, message = "Mesajınız başarıyla gönderildi." });
            }
            return Json(new { success = false, message = "Bir hata oluştu"});

        }
    }
}

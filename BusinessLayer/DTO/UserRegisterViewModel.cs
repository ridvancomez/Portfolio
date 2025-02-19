using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.DTO
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Girin")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı Adı Girin")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Resim Girin")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Lütfen Şifre Adı Girin")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Kullanıcı Adı Girin")]
        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen Email Adı Girin")]
        [EmailAddress(ErrorMessage = "Lütfen Geçerli Bir Email Adı Girin")]
        public string Email { get; set; }
    }
}

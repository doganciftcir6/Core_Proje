using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        //kullanıcı kayıt olurken nelere ihtiyacı var
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen adını giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soy adını giriniz.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen görsel url değeri giriniz.")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi giriniz.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz.")]
        [Compare("Password", ErrorMessage = "Şifreler uyumlu değil.")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen mail adresi giriniz.")]
        public string Mail { get; set; }
    }
}

using Core_Proje.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public ProfileController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //önce kullanıcıyı bulalım ve bunu sayfaya gönderirek sayfa açıldığında ilgili bilgilerin gelmesini sağlayalım.
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            //aşağıda atama yapalım çünkü modele göre işlem gerçekleştirmem gerekiyor
            UserEditViewModel model = new UserEditViewModel();
            model.Name = values.Name;
            model.Surname = values.Surname;
            model.PictureUrl = values.ImageUrl;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEditViewModel)
        {
            //önce ilgili kullanıcıyı bulalım.
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if(userEditViewModel.Picture != null)
            {
                //eğer dışarıdan modelden gelen resim null değilse sen bana bi resim ataması yap
                //önce yolu alalım
                var resource = Directory.GetCurrentDirectory();
                //sonra uzantı
                var extension = Path.GetExtension(userEditViewModel.Picture.FileName);
                //dosya ismini alalım benzersiz
                var imageName = Guid.NewGuid() + extension;
                //resmin kaydedileceği yer
                var saveLocation = resource + "/wwwroot/userimage/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                //Böylece dosya oluşturulacak kopyalama işlemini yapıcaz
                await userEditViewModel.Picture.CopyToAsync(stream);
                user.ImageUrl = imageName;
            }
            //atamalar
            user.Name = userEditViewModel.Name;
            user.Surname = userEditViewModel.Surname;
            //şifre güncelleme işlemi
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditViewModel.Password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                //güncelleme işlemi başarılıysa
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}

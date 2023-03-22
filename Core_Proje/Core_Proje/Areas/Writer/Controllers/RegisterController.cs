using Core_Proje.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
    //Buraya herkes erişebilmeli o yüzden tüm kısıtlamalarını kaldıralım
    [AllowAnonymous]
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }



        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel userRegisterViewModel)
        {
            if (ModelState.IsValid)
            {
                //register işlemi yapılabilir
                //parametreden dışarıdan modelden gelen bilgileri tablomuzdaki user tablosunun bilgilerine atıcaz önce. 
                WriterUser w = new WriterUser()
                {
                    Name = userRegisterViewModel.Name,
                    Surname = userRegisterViewModel.Surname,
                    Email = userRegisterViewModel.Mail,
                    UserName = userRegisterViewModel.UserName,
                    ImageUrl = userRegisterViewModel.ImageUrl
                };
                //kullanıcı oluşturma işlemini burda yaparım artık ve password bilgisini burda al derim.
                if(userRegisterViewModel.Password == userRegisterViewModel.ConfirmPassword)
                {
                    //eğer şifreler uyumluysa kayıt işlemini yap
                     var result = await _userManager.CreateAsync(w,userRegisterViewModel.Password);
               
                if (result.Succeeded)
                {
                    //kullanıcı oluşturma işlemi başarılı olduysa
                    return RedirectToAction("Index","Login");
                }
                else
                {
                    //kullanıcı oluşturma işlemi başarısızsa
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
                }
            }
            return View();
        }
    }
}

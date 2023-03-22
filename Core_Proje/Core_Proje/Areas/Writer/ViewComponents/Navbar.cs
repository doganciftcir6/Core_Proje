using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.ViewComponents
{
    public class Navbar : ViewComponent
    {
        private readonly UserManager<WriterUser> _userManager;

        public Navbar(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //kullanıcın resim bilgisni çekip view'a göndericez.
            //önce kişiyi bul
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            //şimdi bu userin imageurl bilgisini çekip viewbag olarak gönderelim
            ViewBag.v = user.ImageUrl;

            return View();
        }
    }
}

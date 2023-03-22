using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardWriterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardWriterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }


        public async Task<IActionResult> Index()
        {
            //kullanıcıyı bulalım ve kullanıcının ismini ve soy ismini viewbag ile taşıyalım
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = user.Name + " " + user.Surname;


            //istatistiki bilgileri taşımak
            Context context = new Context();
            //toplam gelen mesaj sayısı
            ViewBag.v1 = context.WriterMessages.Where(x=> x.Receiver == user.Email).Count();
            //duyuru sayısı
            ViewBag.v2 = context.Announcements.Count();
            //kullanıcı sayısı
            ViewBag.v3 = context.Users.Count();
            //yetenek sayısı
            ViewBag.v4 = context.Skills.Count();

            return View();
        }
    }
}

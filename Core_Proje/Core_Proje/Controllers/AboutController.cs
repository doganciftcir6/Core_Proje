using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    //BURDA DİREKT OLARAK GÜNCELLEME YAPICAZ.
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());

        [HttpGet]
        public IActionResult Index()
        {
            //önce verileri getireceksin. Zaten tek kayıt var.
            var values = aboutManager.TGetById(1);

            return View(values);
        }
        [HttpPost]
        public IActionResult Index(About about)
        {
            aboutManager.TUpdate(about);

            return RedirectToAction("Index", "Home");
        }
    }
}

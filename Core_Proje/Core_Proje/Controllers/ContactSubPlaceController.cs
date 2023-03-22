using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ContactSubPlaceController : Controller
    {
        ContactManager aboutManager = new ContactManager(new EfContactDal());

        [HttpGet]
        public IActionResult Index()
        {
            //önce verileri getireceksin. Zaten tek kayıt var.
            var values = aboutManager.TGetById(1);

            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            aboutManager.TUpdate(contact);

            return RedirectToAction("Index", "Home");
        }
    }
}

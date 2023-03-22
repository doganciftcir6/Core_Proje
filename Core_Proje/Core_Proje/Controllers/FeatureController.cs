using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    //BURDA DİREKT OLARAK GÜNCELLEME YAPICAZ.
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());

        [HttpGet]
        public IActionResult Index()
        {
            //önce verileri getireceksin. Zaten tek kayıt var.
            var values = featureManager.TGetById(1);

            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            featureManager.TUpdate(feature);

            return RedirectToAction("Index","Home");
        }
    }
}

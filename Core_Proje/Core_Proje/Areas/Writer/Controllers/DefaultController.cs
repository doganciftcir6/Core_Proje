using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());

        public IActionResult Index()
        {
            var response = announcementManager.TGetList();
            return View(response);
        }
        [HttpGet]
        public IActionResult AnnouncementDetails(int id)
        {
            var result = announcementManager.TGetById(id);
            return View(result);
        }
    }
}

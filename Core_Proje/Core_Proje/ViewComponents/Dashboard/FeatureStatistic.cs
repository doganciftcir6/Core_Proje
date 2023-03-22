using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class FeatureStatistic : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            //yetenek sayısı
            ViewBag.V1 = context.Skills.Count();
            //okunmamış mesaj sayısı
            ViewBag.V2 = context.Messages.Where(x=> x.Status == false).Count();
            //okunmuş mesaj sayısı
            ViewBag.V3 = context.Messages.Where(x=> x.Status == true).Count();
            //çalıştığım iş sayısı gibi
            ViewBag.V4 = context.Experiences.Count();

            return View();
        }
    }
}

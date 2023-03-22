using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class StatisticsDashboard2 : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            //proje sayısı
            ViewBag.V1 = context.Portfolios.Count();
            //mesaj sayısı
            ViewBag.V2 = context.Messages.Count();
            //hizmet sayısı
            ViewBag.V3 = context.Services.Count();
            return View();
        }
    }
}

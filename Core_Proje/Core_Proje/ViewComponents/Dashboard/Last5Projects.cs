using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    //SON 5 PROJEMİ GÖSTERECEK BURASI
    public class Last5Projects : ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_Proje.Controllers
{
    //buraya mutlaka erişim sağlanmalı hiç bir kuraldan etkilenememli giriş yapılmasa bile erişim olmalı
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SendMessage(Message message)
        {
            MessageManager messageManager = new MessageManager(new EfMessageDal());

            //OLUŞTURULDUĞU TARİHİ VERİTABANINA YANSITSIN
            message.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            //BAŞLANGIÇTA TRUE OLSUN
            message.Status = true;


            messageManager.TAdd(message);

            return PartialView();
        }
    }
}

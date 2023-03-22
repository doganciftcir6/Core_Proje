using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Core_Proje.Controllers
{
    //AJAX
    public class WriterUserController : Controller
    {
        WriterUserManager writerUserManager = new WriterUserManager(new EfWriterUserDal());
        public IActionResult Index()
        {
            return View();
        }
        //ajax ile listeleme işlemi
        public IActionResult ListUser()
        {
            //ajax ile listeleme
            //sana göndereceğim verileri json türüne çevireceksin.
            //listemele işlemlerinde Serialize kullanıcaz ama biz bir şeyler gönderirken DeSerialize kullanıcaz.
            var values = JsonConvert.SerializeObject(writerUserManager.TGetList());

            return Json(values);

        }
        //ajax ile ekleme işlemi
        [HttpPost]
        public IActionResult AddUser(WriterUser writerUser)
        {
            writerUserManager.TAdd(writerUser);
            //dönüştürmem gerekiyor
            var values = JsonConvert.SerializeObject(writerUser);
            return Json(values);
        }
    }
}

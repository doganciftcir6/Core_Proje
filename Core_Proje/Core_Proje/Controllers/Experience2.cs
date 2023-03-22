using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Core_Proje.Controllers
{
    //EXPERİENCE İLE AYNI İŞLEMLERİ YAPACAK SADECE AJAX ÜZERİNDEN YAPACAK
    public class Experience2 : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            return View();
        }
        //ajax ile listeleme işlemi
        public IActionResult ListExperience()
        {
            //ajax ile listeleme
            //sana göndereceğim verileri json türüne çevireceksin.
            //listemele işlemlerinde Serialize kullanıcaz ama biz bir şeyler gönderirken DeSerialize kullanıcaz.
            var values = JsonConvert.SerializeObject(experienceManager.TGetList());

            return Json(values);

        }
        //ajax ile ekleme işlemi
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceManager.TAdd(experience);
            //dönüştürmem gerekiyor
            var values = JsonConvert.SerializeObject(experience);
            return Json(values);
        }
        //ıdye göre kayıt getirme işlemi
        public IActionResult GetById(int ExperienceId)
        {
            var v = experienceManager.TGetById(ExperienceId);
            var values = JsonConvert.SerializeObject(v);
            return Json(values);
        }
        //silme işlemi
        public IActionResult DeleteExperience(int id)
        {
            var v = experienceManager.TGetById(id);
            experienceManager.TDelete(v);
            return NoContent();
        }
    }
}

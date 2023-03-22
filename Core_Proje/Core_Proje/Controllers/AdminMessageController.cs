using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Core_Proje.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult ReceiverMessageList()
        {
            //admine mesaj atılacak.
            //alıcısı olduğumuz mesajlar
            string p;
            p = "admin@gmail.com";
            var result = writerMessageManager.GetListReceiverMessage(p);
            return View(result);
        }
        public IActionResult SenderMessageList()
        {
            //göndericisi olduğumuz mesajlar
            string p;
            p = "admin@gmail.com";
            var result = writerMessageManager.GetListSenderMessage(p);
            return View(result);
        }
        public IActionResult AdminMessageDetails(int id)
        {
            var result = writerMessageManager.TGetById(id);
            return View(result);
        }
        public IActionResult AdminMessageDelete(int id)
        {
            var result = writerMessageManager.TGetById(id);
            writerMessageManager.TDelete(result);
            return RedirectToAction("SenderMessageList");
        }
        [HttpGet]
        public IActionResult AdminMessageSend()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage writerMessage)
        {
            //gönderici
            writerMessage.Sender = "admin@gmail.com";
            writerMessage.SenderName = "Admin";
            writerMessage.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            //alıcı
            Context context = new Context();
            var usernamesurname = context.Users.Where(x => x.Email == writerMessage.Receiver).Select(x => x.Name + " " + x.Surname).FirstOrDefault();
            writerMessage.ReceiverName = usernamesurname;

            writerMessageManager.TAdd(writerMessage);
            return RedirectToAction("SenderMessageList");
        }
    }
}

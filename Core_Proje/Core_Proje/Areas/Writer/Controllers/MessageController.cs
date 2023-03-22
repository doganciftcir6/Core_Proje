using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Message")]
    public class MessageController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        WriterMessageManager WriterMessageManager = new WriterMessageManager(new EfWriterMessageDal());

        [Route("")]
        [Route("ReceiverMessage")]
        public async Task<IActionResult> ReceiverMessage(string p)
        {
            //şartlı filtreleme yaparak listeyi getirmek.
            //kişiyi bulmak
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            //dışarıdan gelen parametreye değer ataması yapalım
            p = user.Email;
            //bu şekilde maile göre listeleme yapıcaz kullanıcının mailine göre.
            var messageList = WriterMessageManager.GetListReceiverMessage(p);
            
            return View(messageList);
        }
        [Route("")]
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string p)
        {
            //şartlı filtreleme yaparak listeyi getirmek.
            //kişiyi bulmak
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            //dışarıdan gelen parametreye değer ataması yapalım
            p = user.Email;
            //bu şekilde maile göre listeleme yapıcaz kullanıcının mailine göre.
            var messageList = WriterMessageManager.GetListSenderMessage(p);

            return View(messageList);
        }
        [Route("MessageDetails/{id}")]
        public IActionResult MessageDetails(int id)
        {
            var result = WriterMessageManager.TGetById(id);
            return View(result);
        }
        [Route("ReceiverMessageDetails/{id}")]
        public IActionResult ReceiverMessageDetails(int id)
        {
            var result = WriterMessageManager.TGetById(id);
            return View(result);
        }
        [HttpGet]
        [Route("")]
        [Route("SendMessage")]
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        [Route("")]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage(WriterMessage writerMessage)
        {
            Context context = new Context();

            //AŞAĞIDAKİ ATAMA İŞLEMLERİNİ MESAJ EKLEMESİ YAPARKEN KULLANICININ BİLGİLERİNİDE EKLEMESİNİ İSTEDİĞİM İÇİN YAPIYORUM.
            //kişiyi bulmak
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            //dışarıdan gelen mail parametresini db'de bulunen userın mail bilgisine değer ataması yapalım
            string mail = user.Email;
            writerMessage.Sender = mail;
            //şuanın kısa tarih bilgisini atadık.
            writerMessage.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            //kişinin ad soyad bilgisi
            string name = user.Name + " " + user.Surname;
            writerMessage.SenderName = name;

            //mesaj gönderirken alıcı adının eklenmesi
            var usernamesurname = context.Users.Where(x => x.Email == writerMessage.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            writerMessage.ReceiverName = usernamesurname;

     
            WriterMessageManager.TAdd(writerMessage);
            return RedirectToAction("SenderMessage");
        }
    }
}

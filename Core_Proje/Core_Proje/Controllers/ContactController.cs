﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class ContactController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            var result = messageManager.TGetList();
            return View(result);
        }
        public IActionResult DeleteContact(int id)
        {
            var result = messageManager.TGetById(id);
            messageManager.TDelete(result);
            return RedirectToAction("Index");
        }
        public IActionResult ContactDetails(int id)
        {
            var result = messageManager.TGetById(id);
            return View(result);
        }
    }
}

using Jewellery.Models.Concrete;
using Jewellery.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jewellery.Controllers.Admin
{
    public class ContactController : Controller
    {
        
        
        ContactManager contactManager;
        // GET: Contact
     
        
        public ActionResult Index()
        {
            contactManager = new ContactManager();
            var contact = contactManager.GetAll();
            ViewBag.Say = contact.Count();
            return View(contact);
        }

        [HttpGet]
        public ActionResult DeleteContact(int id)
        {
            contactManager = new ContactManager();
            contactManager.DeleteContact(contactManager.GetByID(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddContact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddContact(Contact contact)
        {
            contactManager = new ContactManager();
            contactManager.AddContact(contact);
            return RedirectToAction("Index");
        }



        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            contactManager = new ContactManager();
            var contact = contactManager.GetByID(id);
            return View(contact);
        }
        [HttpPost]
        public ActionResult UpdateContact(Contact contact)
        {
            contactManager = new ContactManager();
            contactManager.UpdateContact(contact);
            return RedirectToAction("Index");
        }
    }

}

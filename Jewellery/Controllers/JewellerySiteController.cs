using Jewellery.Models.Concrete;
using Jewellery.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jewellery.Controllers
{
    public class JewellerySiteController : Controller
    {
        // GET: JewellerySite
        CompanyManager companyManager = new CompanyManager();
        ContactManager contactManager;
        ClientManager clientManager;
        ProductManager productManager=new ProductManager();
        public ActionResult Index()
        {
            ViewBag.Company= companyManager.GetByID(1);
            clientManager = new ClientManager();
            ViewBag.Product1 = productManager.GetByID(1);
            ViewBag.Product2 = productManager.GetByID(5);
            ViewBag.Client = clientManager.GetAll();
            return View();
        }
        [HttpPost]
        public ActionResult AddContact(Contact contact)
        {
            contactManager = new ContactManager();
            contactManager.AddContact(contact);
            return RedirectToAction("Index");
        }
    }
}
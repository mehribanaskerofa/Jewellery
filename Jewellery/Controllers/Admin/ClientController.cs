using Jewellery.Models.Concrete;
using Jewellery.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jewellery.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        ClientManager clientManager;
        public ActionResult Index()
        {
            clientManager = new ClientManager();
            var client=clientManager.GetAll();
            ViewBag.Say = client.Count();
            return View(client);
        }

        [HttpGet]
        public ActionResult DeleteClient(int id)
        {
            clientManager = new ClientManager();
            clientManager.DeleteClient(clientManager.GetByID(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddClient()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddClient(Client client)
        {
            clientManager = new ClientManager();
            clientManager.AddClient(client);
            return RedirectToAction("Index");
        }

       

        [HttpGet]
        public ActionResult UpdateClient(int id)
        {
            clientManager = new ClientManager();
            var client = clientManager.GetByID(id);
            return View(client);
        }
        [HttpPost]
        public ActionResult UpdateClient(Client client)
        {
            clientManager = new ClientManager();
            clientManager.UpdateClient(client);
            return RedirectToAction("Index");
        }
    }

}
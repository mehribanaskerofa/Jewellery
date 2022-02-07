using Jewellery.Models;
using Jewellery.Models.Concrete;
using Jewellery.Models.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jewellery.Controllers.Admin
{
    public class ProductController : Controller
    {
        
        
        ProductManager productManager = new ProductManager();
        // GET: Product_
        public ActionResult Index()
        {
            var allEntity = productManager.GetAll();
            ViewBag.PSay = allEntity.Count;
            ViewBag.Products = allEntity;
            return View();
        }


        [HttpGet]
        public ActionResult AddProduct()
        {          
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
           // string fileName =Path.GetFileNameWithoutExtension( product.PImg.i);
           //string extension= Path.GetExtension(product.PImg);
           //fileName = fileName+DateTime.Now.ToString("yymmssfff") +extension;
           // product.PImg = "~/Image/" + fileName;
           // fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);

           // product.PImg = fileName;

            product.Status = true;

            productManager.AddProduct(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeleteProduct(int id)
        {
           
            var product=productManager.GetByID(id);

            if (product != null)
            {
                productManager.DeleteProduct(product);
                
                return RedirectToAction("Index");
            }
            return View("Index");
        }





        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            var uproduct = productManager.GetByID(id);
            //var value = JsonConvert.SerializeObject(uproduct, Formatting.Indented, new JsonSerializerSettings
            //{
            //    ReferenceLoopHandling=ReferenceLoopHandling.Ignore
            //});

            return View(uproduct);
        }

        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {
            productManager.UpdateProduct(product);

            return RedirectToAction("Index");
        }


        //public JsonResult EditProduct(int id)
        //{
        //    var produkt = productManager.GetByID(id);
        //    return Json(produkt, JsonRequestBehavior.AllowGet);
        //}
    }
}
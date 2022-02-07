using Jewellery.Models.Concrete;
using Jewellery.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jewellery.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        CompanyManager companyManager ;
        public ActionResult Index()
        {
            companyManager = new CompanyManager();
            var companies=companyManager.GetAll();
            @ViewBag.Say = companies.Count;
            return View(companies);
        }

        [HttpGet]
        public ActionResult AddCompany()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCompany(Company company)
        {
            companyManager = new CompanyManager();
            companyManager.AddCompany(company);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeleteCompany(int id)
        {
            companyManager = new CompanyManager();
            companyManager.DeleteCompany(companyManager.GetByID(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCompany(int id)
        {
            companyManager = new CompanyManager();
            var company = companyManager.GetByID(id);
            return View(company);
        }
        [HttpPost]
        public ActionResult UpdateCompany(Company company)
        {
            companyManager = new CompanyManager();
            companyManager.UpdateCompany(company);
            return RedirectToAction("Index");
        }
    }
}
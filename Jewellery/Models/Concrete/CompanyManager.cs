using Jewellery.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Jewellery.Models.Concrete
{
    public class CompanyManager
    {
        Context c = new Context();
        public void AddCompany(Company company)
        {
            c.Companies.Add(company);
            c.SaveChanges();           
        }
        public void DeleteCompany(Company company)
        {
            c.Companies.Remove(company);
            c.SaveChanges();
        }
        public List<Company> GetAll()
        {
            return c.Companies.ToList();
        }
        public Company GetByID(int id)
        {
            return c.Companies.Where(x => x.ID == id).FirstOrDefault();
        }
        public void UpdateCompany(Company company)
        {
            var updatedEntity = c.Entry(company);
              updatedEntity.State = EntityState.Modified;
          
            c.SaveChanges();
        }
       
    }
}

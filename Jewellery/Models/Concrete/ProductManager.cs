using Jewellery.Models.Abstract;
using Jewellery.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Jewellery.Models.Concrete
{
    public class ProductManager :  IProduct
    {
        //Repository<Product> repository=new Repository<Product>();


        Context c = new Context();
        //DbSet<Product> _object;
        //public ProductManager(Repository<Product> _repository)
        //{
        //    _repository = repository;
        //}

        public void AddProduct(Product product)
        {
            
            c.Products.Add(product);
            c.SaveChanges();
            //repository.Added(product);
        }

        public void DeleteProduct(Product product)
        {
            c.Products.Remove(product);
            c.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return c.Products.ToList();
        }

        public Product GetByID(int id)
        {
            return c.Products.Where(x=>x.ID==id).FirstOrDefault();
        }

        public void UpdateProduct(Product product)
        {
            var updatedEntity = c.Entry(product);
            updatedEntity.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
using Jewellery.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewellery.Models.Abstract
{
    public interface IProduct
    {
        List<Product> GetAll();
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        void AddProduct(Product product);

        Product GetByID(int id);
    }
}

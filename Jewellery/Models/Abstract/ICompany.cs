using Jewellery.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewellery.Models.Abstract
{
    public interface ICompany
    {
        List<Company> GetAll();
        void UpdateCompany(Company company);
        void DeleteCompany(Company company);
        void AddCompany(Company company);

        Company GetByID(int id);
    }
}

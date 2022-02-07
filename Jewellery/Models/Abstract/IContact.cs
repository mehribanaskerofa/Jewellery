using Jewellery.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewellery.Models.Abstract
{
    public interface IContact
    {
        List<Contact> GetAll();
        void UpdateContact(Contact contact);
        void DeleteContact(Contact contact);
        void AddContact(Contact contact);

        Contact GetByID(int id);
    }
}

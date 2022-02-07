using Jewellery.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Jewellery.Models.Concrete
{
    public class ContactManager
    {
        Context c = new Context();
        public void AddContact(Contact contact)
        {
            c.Contacts.Add(contact);
            c.SaveChanges();
        }
        public void DeleteContact(Contact contact)
        {
            c.Contacts.Remove(contact);
            c.SaveChanges();
        }
        public List<Contact> GetAll()
        {
            return c.Contacts.ToList();
        }
        public Contact GetByID(int id)
        {
            return c.Contacts.Where(x => x.ID == id).FirstOrDefault();
        }
        public void UpdateContact(Contact contact)
        {
            var updatedEntity = c.Entry(contact);
            updatedEntity.State = EntityState.Modified;

            c.SaveChanges();
        }

    }
}
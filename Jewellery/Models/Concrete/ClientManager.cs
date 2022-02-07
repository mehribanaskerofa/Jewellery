using Jewellery.Models.Abstract;
using Jewellery.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Jewellery.Models.Concrete
{
    public class ClientManager : IClient
    {
        Context context ;
        public void AddClient(Client client)
        {
            context = new Context();
            context.Clients.Add(client);
            context.SaveChanges();
        }

        public void DeleteClient(Client client)
        {
            context = new Context();
            context.Clients.Remove(client);
            context.SaveChanges();
        }

        public List<Client> GetAll()
        {
            context = new Context();
            return context.Clients.ToList();
        }

        public Client GetByID(int id)
        {
            context = new Context();
            return context.Clients.Where(x => x.ID == id).FirstOrDefault();
        }

        public void UpdateClient(Client client)
        {
            context = new Context();
            var clientEntity = context.Entry(client);
            clientEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
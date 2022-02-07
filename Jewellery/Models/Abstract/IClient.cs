using Jewellery.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewellery.Models.Abstract
{
    public interface IClient
    {
        List<Client> GetAll();
        void UpdateClient(Client client);
        void DeleteClient(Client client);
        void AddClient(Client client);
        Client GetByID(int id);
    }
}

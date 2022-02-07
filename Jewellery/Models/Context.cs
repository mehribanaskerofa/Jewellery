using Jewellery.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Jewellery.Models
{
    public class Context:DbContext
    {
        public DbSet<Company>  Companies{ get; set; }
        public DbSet<Product>  Products{ get; set; }
        public DbSet<Client>  Clients{ get; set; }
        public DbSet<Contact>  Contacts{ get; set; }

    }
}
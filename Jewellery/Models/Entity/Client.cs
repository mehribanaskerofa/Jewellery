using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jewellery.Models.Entity
{
    public class Client
    {
        [Key]
        public int ID { get; set; }
        public string CFullName { get; set; }
        public string CComment { get; set; }
    }
}
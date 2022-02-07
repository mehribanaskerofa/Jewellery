using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jewellery.Models.Entity
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }
        public string CName { get; set; }
        public string CPhone { get; set; }
        public string CEmail { get; set; }
        public string CMessage { get; set; }
        public bool CStatus { get; set; }
    }
}
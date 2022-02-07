using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jewellery.Models.Entity
{
    public class Company
    {
        [Key]
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public int CompanyImg { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyEmail { get; set; }
      
    }
}
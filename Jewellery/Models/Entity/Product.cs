using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jewellery.Models.Entity
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string PName { get; set; }
        public string PContent { get; set; }
        public string PImg { get; set; }
        public int Price { get; set; }
        public  bool Status{ get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FurnitureStoreFinal.Models
{
    public class Stock
    {
        public int id { get; set; }

        [Display(Name = "Product ")]
        public string Product { get; set; }

        [Display(Name = "Quantity  ")]
        public int Quantity { get; set; }


    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectV1.Models
{
    public class Item
    {
        public long Id{ get; set; }
        [Display (Name = "Item Name")]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        [Display (Name = "2000 EGP")]
        public string Price{ get; set; }

        public int Quantity { get; set; }
    }
}

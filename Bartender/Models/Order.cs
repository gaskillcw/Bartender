using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bartender.Models
{
    public class Order
    {
        public string OrderID { get; set; }
        public string Username { get; set; }
        public string Item { get; set; }
        public float Price { get; set; }
    }
}

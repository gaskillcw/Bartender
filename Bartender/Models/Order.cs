using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bartender.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public User Customer { get; set; }
        public Drink Item { get; set; }
    }
}

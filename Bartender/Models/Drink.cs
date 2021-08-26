using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bartender.Models
{
    public class Drink
    {
        public Drink()
        {
            Ingredients = new List<string>();
        }

        public string Name { get; set; }
        public float Price { get; set; }
        public List<string> Ingredients { get; set; }
    }
}

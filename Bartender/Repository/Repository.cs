using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bartender.Models;

namespace Bartender.Repository
{
    public class Repository
    {
        public List<User> Users;
        public List<Drink> Drinks;
        public List<Order> Orders;

        public Repository()
        {
            // create list of users
            Users = new List<User>();

            // populate list of users
            Users.Add(new User()
            {
                Username = "gaskillcw",
                Password = "test",
                Roles = { "Staff" }
            });

            Users.Add(new User()
            {
                Username = "sacarali",
                Password = "test",
                Roles = { "Customer" }
            });

            // create list of drinks
            Drinks = new List<Drink>();

            // populate list of drinks
            Drinks.Add(new Drink()
            {
                Name = "Pina Colada",
                Price = 11.99F,
                Ingredients = {"1/2 - Pineapple", "6 ounces - Cream of coconut", 
                    "2 ounces - Coconut milk", "8 ounces - White rum", 
                "2 tablespoons - Fresh lime juice", "2 ounces - Dark rum (optional)",
                "1 Banana", "Maraschino cherries and lime wedges (for serving)"}
            });

            // create list of orders
            Orders = new List<Order>();

            // populate list of orders
            Orders.Add(new Order()
            {
                OrderID = Guid.NewGuid().ToString()
            });




        } // end Repository method

    } // end Repository class

} // end Repository namespace

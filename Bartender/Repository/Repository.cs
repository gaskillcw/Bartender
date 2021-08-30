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
                Ingredients = "Pineapple, Cream of coconut, " +
                "Coconut milk, White rum, " +
                "Fresh lime juice, Dark rum (optional), " +
                "Banana, Maraschino cherries and lime wedges (for serving)"
            });

            Drinks.Add(new Drink()
            {
                Name = "Whiskey Sour",
                Price = 8.99F,
                Ingredients = "Bourbon, Fresh lemon juice, " +
                "Simple syrup, and orange wedges and Maraschino cherries (for serving)"
            });

            // create list of orders
            Orders = new List<Order>();

            // populate list of orders
            Orders.Add(new Order()
            {
                OrderID = Guid.NewGuid().ToString(),
                Username = "sacarali",
                Item = "Pina Colada"
            });




        } // end Repository method

    } // end Repository class

} // end Repository namespace

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

        public Repository()
        {
            Users = new List<User>();
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


        } // end Repository method

    } // end Repository class

} // end Repository namespace

using DrinkOrderMVC.Model;
using DrinkOrderMVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkOrderMVC.Controller
{
    class AppController
    {
        private User customer;
        private DrinkCollections drinkCollections;
        
        public AppController()
        {
            this.customer = new User();
            this.drinkCollections = new DrinkCollections();
        }

        public void addCustomer(User user)
        {
            this.customer = user;
        }

        public User getCustomer()
        {
            return this.customer;
        }

        public Drink getDrinkByName(String name)
        {
            return this.drinkCollections.findDrink(name);
        }
    }
}

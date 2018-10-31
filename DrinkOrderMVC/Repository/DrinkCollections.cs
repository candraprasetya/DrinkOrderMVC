using DrinkOrderMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkOrderMVC.Repository
{
    class DrinkCollections
    {
        private List<Drink> collections;
        public DrinkCollections()
        {
            this.collections = new List<Drink>();
            generateCollection();
        }

        private void generateCollection()
        {

           //this.collections.Add(new Drink("brand of drinks", "price")
            this.collections.Add(new Drink("Cappucino", 25000));
            this.collections.Add(new Drink("Americano", 23000));
            this.collections.Add(new Drink("Ice Tea", 20000));
            this.collections.Add(new Drink("Thai Tea", 18000));
            this.collections.Add(new Drink("Chocolate", 10000));
            this.collections.Add(new Drink("Coffee Latte", 25000));
            this.collections.Add(new Drink("Lemon Tea", 17000));
            this.collections.Add(new Drink("Milk", 21000));
        }

        public List<Drink> getCollections()
        {
            return this.collections;
        }

        public Drink findDrink(String brand)
        {
            foreach(Drink drink in collections)
            {
                if (drink.getBrand().Equals(brand))
                {
                    return drink;
                }
            }
            return null;
        }
    }
}

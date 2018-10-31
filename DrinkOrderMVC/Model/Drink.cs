using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkOrderMVC.Model
{
    class Drink
    {
        private String brand;
        private Double price;

        public Drink(string Brand,double Price)
        {
            this.brand = Brand;
            this.price = Price;
        }

        public String getBrand()
        {
            return this.brand;
        }

        public Double getPrice()
        {
            return this.price;
        }
    }
}

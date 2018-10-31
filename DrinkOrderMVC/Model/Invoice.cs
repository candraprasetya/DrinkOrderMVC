using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkOrderMVC.Model
{
    class Invoice
    {
        private List<Drink> ordered;
        private Double totalPrice = 0;
        private Boolean paid;

        public Invoice()
        {
            ordered = new List<Drink>();
        }

        public void addOrder(Drink drink)
        {
            this.ordered.Add(drink);
        }

        public Double getTotalPrice()
        {
            foreach(Drink drink in ordered)
            {
                totalPrice += drink.getPrice();
            }
            return totalPrice;
        }

        public void setPaid()
        {
            this.paid = true;
        }

        public Boolean isPaid()
        {
            return this.paid;
        }

        public List<Drink> getOrderedItems()
        {
            return this.ordered;
        }
    }
}

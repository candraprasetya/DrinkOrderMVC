using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkOrderMVC.Model
{
    class User
    {
        private Invoice purchased;
        private String name;

        public User()
        {
            this.purchased = new Invoice();
        }

        public void makeInvoice(Invoice invoice)
        {
            this.purchased = invoice;
        }

        public void setName(String Name)
        {
            this.name = Name;
        }

        public String getName()
        {
            return this.name;
        }

        public Invoice getInvoice()
        {
            return this.purchased;
        }
    }
}

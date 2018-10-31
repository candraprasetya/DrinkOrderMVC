using DrinkOrderMVC.Controller;
using DrinkOrderMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DrinkOrderMVC.View
{
    /// <summary>
    /// Interaction logic for ConfirmationView.xaml
    /// </summary>
    public partial class ConfirmationView : Window
    {
        AppController app;
        User customer;
        public ConfirmationView()
        {
            InitializeComponent();

            app = (AppController)Application.Current.Properties["ApplicationController"];
            customer = app.getCustomer();

            Invoice invoice = customer.getInvoice();

            this.labelTotalPrice.Content = "IDR " + invoice.getTotalPrice();

            displayDataIntoListView();
        }

        private void displayDataIntoListView()
        {
            foreach (Drink drink in customer.getInvoice().getOrderedItems())
            {
                this.ListViewOrder.Items.Add(drink.getBrand());
            }
        }

        private void buttonPay_Click(object sender, RoutedEventArgs e)
        {
            customer.setName(this.textboxUsername.Text);
            if (textboxUsername.Text == "")
            {
                MessageBox.Show("Please enter your name first!");
            }
            else
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                foreach (object item in ListViewOrder.Items)
                {
                    sb.Append("- " + item.ToString());
                    sb.Append("\n");
                }

                MessageBox.Show("Name : " + customer.getName().ToString() + "\n" + "\n" + "Your Order : " + "\n" + sb.ToString() + "\n" + "\n" + "TOTAL : " + labelTotalPrice.Content.ToString());
            }
        }
    }
}

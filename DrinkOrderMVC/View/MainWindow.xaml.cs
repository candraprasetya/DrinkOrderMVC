using DrinkOrderMVC.Controller;
using DrinkOrderMVC.Model;
using DrinkOrderMVC.View;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DrinkOrderMVC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private User newCustomer;
        private Invoice newInvoice;
        private AppController app;

        public MainWindow()
        {
            InitializeComponent();

            newCustomer = new User();
            newInvoice = new Invoice();

            app = new AppController();
            app.addCustomer(newCustomer);
            noOrder.IsChecked = true;
            noOrder.Visibility = System.Windows.Visibility.Hidden;

            Application.Current.Properties["ApplicationController"] = app;
        }

        private void buttonCappucino_Click(object sender, RoutedEventArgs e)
        {
            noOrder.IsChecked = false;
            Drink cappucino = app.getDrinkByName("Cappucino");
            newInvoice.addOrder(cappucino);
            this.buttonCappucino.IsEnabled = false;
        }

        private void buttonAmericano_Click(object sender, RoutedEventArgs e)
        {
            noOrder.IsChecked = false;
            Drink americano = app.getDrinkByName("Americano");
            newInvoice.addOrder(americano);
            this.buttonAmericano.IsEnabled = false;
        }

        private void buttonThaiTea_Click(object sender, RoutedEventArgs e)
        {
            noOrder.IsChecked = false;
            Drink thaiTea = app.getDrinkByName("Thai Tea");
            newInvoice.addOrder(thaiTea);
            this.buttonThaiTea.IsEnabled = false;
        }

        private void buttonIceTea_Click(object sender, RoutedEventArgs e)
        {
            noOrder.IsChecked = false;
            Drink iceTea = app.getDrinkByName("Ice Tea");
            newInvoice.addOrder(iceTea);
            this.buttonIceTea.IsEnabled = false;
        }

        private void buttonCoffeeLatte_Click(object sender, RoutedEventArgs e)
        {
            noOrder.IsChecked = false;
            Drink coffeeLatte = app.getDrinkByName("Coffee Latte");
            newInvoice.addOrder(coffeeLatte);
            this.buttonCoffeeLatte.IsEnabled = false;
        }

        private void buttonChocolatos_Click(object sender, RoutedEventArgs e)
        {
            noOrder.IsChecked = false;
            Drink chocolate = app.getDrinkByName("Chocolate");
            newInvoice.addOrder(chocolate);
            this.buttonChocolatos.IsEnabled = false;
        }

        private void buttonMilk_Click(object sender, RoutedEventArgs e)
        {
            noOrder.IsChecked = false;
            Drink milk = app.getDrinkByName("Milk");
            newInvoice.addOrder(milk);
            this.buttonMilk.IsEnabled = false;
        }

        private void buttonLemonTea_Click(object sender, RoutedEventArgs e)
        {
            noOrder.IsChecked = false;
            Drink lemonTea = app.getDrinkByName("Lemon Tea");
            newInvoice.addOrder(lemonTea);
            this.buttonLemonTea.IsEnabled = false;
        }

        private void buttonAmericano_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (noOrder.IsChecked == true)
            {
                MessageBox.Show("Silahkan pilih order terlebih dahulu!");
            }
            else
            {
                newCustomer.makeInvoice(newInvoice);

                Console.WriteLine(newCustomer.getInvoice().getOrderedItems().Contains(app.getDrinkByName("Cappucino")));//seharusnya bernilai true
                Console.WriteLine(newCustomer.getInvoice().getOrderedItems().Contains(app.getDrinkByName("Americano")));//seharusnya bernilai true
                Console.WriteLine(newCustomer.getInvoice().getOrderedItems().Contains(app.getDrinkByName("Chocolate")));//seharusnya bernilai true
                Console.WriteLine(newCustomer.getInvoice().getOrderedItems().Contains(app.getDrinkByName("Coffe Late")));//seharusnya bernilai false
                Console.WriteLine(newCustomer.getInvoice().getOrderedItems().Contains(app.getDrinkByName("Thai Tea")));//seharusnya bernilai false
                Console.WriteLine(newCustomer.getInvoice().getOrderedItems().Contains(app.getDrinkByName("Ice Tea")));//seharusnya bernilai false


                Console.WriteLine(newCustomer.getInvoice().getOrderedItems().Contains(app.getDrinkByName("Cappucino")));//seharusnya bernilai true
                Console.WriteLine(newCustomer.getInvoice().getOrderedItems().Contains(app.getDrinkByName("Americano")));//seharusnya bernilai true
                Console.WriteLine(newCustomer.getInvoice().getOrderedItems().Contains(app.getDrinkByName("Chocolate")));//seharusnya bernilai true
                Console.WriteLine(newCustomer.getInvoice().getOrderedItems().Contains(app.getDrinkByName("Coffe Late")));//seharusnya bernilai true
                Console.WriteLine(newCustomer.getInvoice().getOrderedItems().Contains(app.getDrinkByName("Thai Tea")));//seharusnya bernilai true
                Console.WriteLine(newCustomer.getInvoice().getOrderedItems().Contains(app.getDrinkByName("Ice Tea")));//seharusnya bernilai true

                ConfirmationView nextWindow = new ConfirmationView();
                nextWindow.Show();
                this.Close();
            }
        }
    }
}

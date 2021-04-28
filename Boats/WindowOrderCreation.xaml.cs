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

namespace BoatsProject
{
    /// <summary>
    /// Логика взаимодействия для WindowOrderCreation.xaml
    /// </summary>
    public partial class WindowOrderCreation : Window
    {
        Orders myOrder = new Orders();

        public WindowOrderCreation()
        {
            InitializeComponent();

            cbCustomers.ItemsSource = DBBoats.db.Customers.ToList();
            cbManagers.ItemsSource = DBBoats.db.Managers.ToList();
            cbBoats.ItemsSource = DBBoats.db.Boats.ToList();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            new WindowUserMenu().Show();
            Close();
        }

        private void Conf_Click(object sender, RoutedEventArgs e)
        {
            DateTime curDate = DateTime.Now;

            myOrder.CreationDate = curDate;
            myOrder.Managers = cbManagers.SelectedItem as Managers;
            myOrder.Customers = cbCustomers.SelectedItem as Customers;
            myOrder.Boats = cbBoats.SelectedItem as Boats;
            myOrder.Addr = Addr.Text;
            DBBoats.db.Orders.Add(myOrder);
            DBBoats.db.SaveChanges();
            MessageBox.Show("Заказ успешно добавлен", "Уведомение");
            new WindowUserMenu().Show();
            Close();
        }
    }
}

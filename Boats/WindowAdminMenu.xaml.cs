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
    /// Логика взаимодействия для WindowAdminMenu.xaml
    /// </summary>
    public partial class WindowAdminMenu : Window
    {
        public WindowAdminMenu()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, RoutedEventArgs e)
        {
            new WindowEditUsers().Show();
            Close();
        }

        private void Products_Click(object sender, RoutedEventArgs e)
        {
            new WindowProducts().Show();
            Close();
        }
    }
}

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
    /// Логика взаимодействия для WindowUserMenu.xaml
    /// </summary>
    public partial class WindowUserMenu : Window
    {
        public WindowUserMenu()
        {
            InitializeComponent();
        }

        private void NewOrder_Click(object sender, RoutedEventArgs e)
        {
            new WindowOrderCreation().Show();
            Close();
        }
    }
}

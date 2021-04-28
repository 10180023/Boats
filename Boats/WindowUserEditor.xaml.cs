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
    /// Логика взаимодействия для WindowUserEditor.xaml
    /// </summary>
    public partial class WindowUserEditor : Window
    {
        Users myUser { get; set; }

        public WindowUserEditor(Users users)
        {
            InitializeComponent();
            myUser = users;
        }

        private void Conf_Click(object sender, RoutedEventArgs e)
        {
            myUser.Login = Login.Text;
            myUser.Password = Pass.Text;
            myUser.Role = Role.Text;
            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

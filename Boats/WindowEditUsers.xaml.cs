using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для WindowEditUsers.xaml
    /// </summary>
    public partial class WindowEditUsers : Window
    {
        public WindowEditUsers()
        {
            InitializeComponent();
            DBBoats.db.Users.Load();
            dgUsers.ItemsSource = DBBoats.db.Users.Local.ToList();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Users users = dgUsers.SelectedItem as Users;
            WindowUserEditor userEditor = new WindowUserEditor(users);

            userEditor.Login.Text = users.Login;
            userEditor.Pass.Text = users.Password;
            userEditor.Role.Text = users.Role;

            if (userEditor.ShowDialog() == true)
            {
                DBBoats.db.SaveChanges();
                dgUsers.ItemsSource = DBBoats.db.Users.ToList();
                dgUsers.Items.Refresh();
            }
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            Users users = dgUsers.SelectedItem as Users;

            MessageBoxResult res = MessageBox.Show("Вы действительно хотите удалить пользователя?", "Achtung!", MessageBoxButton.YesNo);
            if (res == MessageBoxResult.Yes)
            {
                MessageBox.Show("Пользовател удален");
                DBBoats.db.Users.Remove(users);
                DBBoats.db.SaveChanges();
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            new WindowAdminMenu().Show();
            Close();
        }
    }
}

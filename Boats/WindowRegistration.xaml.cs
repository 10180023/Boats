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
    /// Логика взаимодействия для WindowRegistration.xaml
    /// </summary>
    public partial class WindowRegistration : Window
    {
        BoatsEntities db = new BoatsEntities();

        public WindowRegistration()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Conf_Click(object sender, RoutedEventArgs e)
        {
            Users users = new Users();

            string login = Login.Text;
            string pass = Pass.Text;
            string role = Role.Text;

            if (pass == PassRep.Text)
            {
                Users user = db.Users.Where(u => u.Login == Login.Text).FirstOrDefault();
                if (user == null)
                {
                    if (login == "" || role == "" || pass == "")
                    {
                        MessageBox.Show("Заполните все поля", "Achtung!");
                    }
                    else
                    {
                        users.Login = login;
                        users.Password = pass;
                        users.Role = role;
                        //db.Users.Add(users);
                        //db.SaveChanges();
                        MessageBox.Show("Пользователь успешно зарегистрирован", "Уведомление");
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином уже существует", "Achtung!");
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают", "Achtung!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace BoatsProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int timerCounter = 0;
        public int blockTime = 15;
        public int counter = 0;
        BoatsEntities db = new BoatsEntities();
        public DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Users user = db.Users.Where(u => u.Login == Login.Text).FirstOrDefault();
            
            if (user != null)
            {
                if (user.Password == Pass.Password)
                {
                    switch (user.Role)
                    {
                        case "A":
                            new WindowAdminMenu().Show(); Close(); break;
                        case "U":
                            new WindowUserMenu().Show(); Close(); break;
                    }
                }
                else
                {
                    MessageBox.Show("Проверьте правильность данных", "Предупреждение");
                    counter++;
                    if (counter == 3)
                    {
                        timer.Start();
                        counter = 0;
                    }
                }
            }
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            btnLogin.IsEnabled = false;
            timerCounter++;
            if (timerCounter == blockTime)
            {
                timer.Stop();
                btnLogin.IsEnabled = true;
                blockTime += 20;
                timerCounter = 0;
            }
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            new WindowRegistration().Show();
        }
    }
}

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
    /// Логика взаимодействия для WindowBoatAdd.xaml
    /// </summary>
    public partial class WindowBoatAdd : Window
    {
        Boats myBoat = new Boats();

        public WindowBoatAdd()
        {
            InitializeComponent();
            BoatType.ItemsSource = DBBoats.db.BoatTypes.ToList();
            Color.ItemsSource = DBBoats.db.Colors.ToList();
            WoodType.ItemsSource = DBBoats.db.WoodTypes.ToList();
        }

        private void Conf_Click(object sender, RoutedEventArgs e)
        {
            myBoat.BoatId = 400;
            myBoat.Title = Title.Text;
            myBoat.BoatTypes = BoatType.SelectedItem as BoatTypes;
            myBoat.RowersAmount = int.Parse(Rowers.Text);
            if (Mast.Text == "Присутствует")
            {
                myBoat.Mast = true;
            }
            else
            {
                myBoat.Mast = false;
            }
            myBoat.Colors = Color.SelectedItem as Colors;
            myBoat.WoodTypes = WoodType.SelectedItem as WoodTypes;
            myBoat.BasePrice = decimal.Parse(Price.Text);
            myBoat.VAT = decimal.Parse(VAT.Text);
            DBBoats.db.Boats.Add(myBoat);
            DBBoats.db.SaveChanges();
            MessageBox.Show("Товар успешно добавлен", "Уведомление");
            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

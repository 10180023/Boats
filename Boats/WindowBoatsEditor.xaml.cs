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
    /// Логика взаимодействия для WindowBoatsEditor.xaml
    /// </summary>
    public partial class WindowBoatsEditor : Window
    {
        Boats myBoat { get; set; }

        public WindowBoatsEditor(Boats boats)
        {
            InitializeComponent();
            myBoat = boats;
            
        }

        private void Conf_Click(object sender, RoutedEventArgs e)
        {
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
            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BoatType.SelectedItem = myBoat.BoatTypes;
            Color.SelectedItem = myBoat.Colors;
            WoodType.SelectedItem = myBoat.WoodTypes;
        }
    }
}

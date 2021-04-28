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
    /// Логика взаимодействия для WindowProducts.xaml
    /// </summary>
    public partial class WindowProducts : Window
    {
        public WindowProducts()
        {
            InitializeComponent();
            DBBoats.db.Boats.Load();
            DBBoats.db.BoatTypes.Load();
            DBBoats.db.Colors.Load();
            DBBoats.db.WoodTypes.Load();
            dgProducts.ItemsSource = DBBoats.db.Boats.ToList();
            
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            new WindowAdminMenu().Show();
            Close();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Boats boats = dgProducts.SelectedItem as Boats;
            WindowBoatsEditor boatsEditor = new WindowBoatsEditor(boats);

            boatsEditor.Title.Text = boats.Title;
            boatsEditor.BoatType.ItemsSource = DBBoats.db.BoatTypes.ToList();
            boatsEditor.Rowers.Text = boats.RowersAmount.ToString();
            if (boats.Mast.ToString() == "True")
            {
                boatsEditor.Mast.Text = "Присутствует";
            }
            else
            {
                boatsEditor.Mast.Text = "Отсутствует";
            }
            boatsEditor.Color.ItemsSource = DBBoats.db.Colors.ToList();
            boatsEditor.WoodType.ItemsSource = DBBoats.db.WoodTypes.ToList();
            boatsEditor.Price.Text = boats.BasePrice.ToString();
            boatsEditor.VAT.Text = boats.VAT.ToString();

            if (boatsEditor.ShowDialog() == true)
            {
                DBBoats.db.SaveChanges();
                dgProducts.ItemsSource = DBBoats.db.Boats.ToList();
                dgProducts.Items.Refresh();
            }
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(new WindowBoatAdd().ShowDialog() == true)
            {
                DBBoats.db.SaveChanges();
                dgProducts.ItemsSource = DBBoats.db.Boats.ToList();
                dgProducts.Items.Refresh();
            }
        }
    }
}

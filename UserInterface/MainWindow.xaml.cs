using Backend_CRUD.Repozytorium;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UbranieRepozytorium ubranieRepozytorium { get; set; }

        public MainWindow()
        {
            InitializeComponent(); //renderowanie
            ubranieRepozytorium = new UbranieRepozytorium();
            UbraniaGrid.ItemsSource = ubranieRepozytorium.GetAll();
            DodajUbranieBtn.Click += DodajUbranieBtn_Click;
            OdswiezBtn.Click += OdswiezBtn_Click;
            UsunUbranieBtn.Click += UsunUbranieBtn_Click;
        }

        private void UsunUbranieBtn_Click(object sender, RoutedEventArgs e)
        {
            var Item = UbraniaGrid.SelectedItem;
            ubranieRepozytorium.Remove(Item);
            MessageBox.Show("Removed!");
        }

        private void OdswiezBtn_Click(object sender, RoutedEventArgs e)
        {
            UbraniaGrid.ItemsSource = ubranieRepozytorium.GetAll();
            MessageBox.Show("Refreshed!");
        }

        private void DodajUbranieBtn_Click(object sender, RoutedEventArgs e)
        {
            var Item = UbraniaGrid.SelectedItem;
            ubranieRepozytorium.Add(Item);
            MessageBox.Show("Added!");
        }
    }
}

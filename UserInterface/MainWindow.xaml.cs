using Backend_CRUD.DB_Tables;
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
        private UbranieRepozytorium ubraniaRepozytorium;
        public MainWindow()
        {
            InitializeComponent();
            ubraniaRepozytorium = new UbranieRepozytorium();

            UbraniaGrid.ItemsSource = ubraniaRepozytorium.GetAll();
            DodajPrzycisk.Click += new RoutedEventHandler(DodajButton_Click);
            AktualizujPrzycik.Click += new RoutedEventHandler(AktualizujButton_Click);
            UsunPrzycisk.Click += new RoutedEventHandler(UsunButton_Click);
            OdswiezPrzycisk.Click += new RoutedEventHandler(OdswiezButton_Click);
            PokazPrzycisk.Click += new RoutedEventHandler(PokazButton_Click);
        }

        private void DataGrid_OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyName.Contains("Wirtualne"))
            {
                e.Column.Visibility = Visibility.Hidden;
            }
            else if (e.PropertyName == "Id")
            {
                e.Column.IsReadOnly = true;
            }
        }

        private void DodajButton_Click(object sender, RoutedEventArgs e)
        {
            var item = UbraniaGrid.SelectedItem;
            ubraniaRepozytorium.Add(item);
            UbraniaGrid.ItemsSource = ubraniaRepozytorium.GetAll();
            MessageBox.Show("Dodane");
        }

        private void AktualizujButton_Click(object sender, RoutedEventArgs e)
        {
            var item = UbraniaGrid.SelectedItem;
            ubraniaRepozytorium.Update(item);
            UbraniaGrid.ItemsSource = ubraniaRepozytorium.GetAll();
            MessageBox.Show("Zaktualizowane");
        }

        private void UsunButton_Click(object sender, RoutedEventArgs e)
        {
            var item = (Ubranie)UbraniaGrid.SelectedItem;
            ubraniaRepozytorium.Remove(item.Id);
            UbraniaGrid.ItemsSource = ubraniaRepozytorium.GetAll();
            MessageBox.Show("Usuniete");
        }

        private void OdswiezButton_Click(object sender, RoutedEventArgs e)
        {
            UbraniaGrid.ItemsSource = ubraniaRepozytorium.GetAll();
            MessageBox.Show("Odswiezone");
        }

        private void PokazButton_Click(object sender, RoutedEventArgs e)
        {
            ParametryUbran clothesParamsWindow = new ParametryUbran();
            clothesParamsWindow.Show();
        }
    }
}

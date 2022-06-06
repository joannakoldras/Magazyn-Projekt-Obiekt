using Backend_CRUD.DB_Tables;
using Backend_CRUD.Repozytorium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UserInterface
{
    /// <summary>
    /// Interaction logic for ParametryUbran.xaml
    /// </summary>
    public partial class ParametryUbran : Window
    {
        private KolorRepozytorium koloryRepozytorium;
        private MarkaRepozytrium markaRepozytorium;
        private KategoriaRepozytrium kategoriaRepozytorium;

        public ParametryUbran()
        {
            InitializeComponent();

            koloryRepozytorium = new KolorRepozytorium();
            markaRepozytorium = new MarkaRepozytrium();
            kategoriaRepozytorium = new KategoriaRepozytrium();

            KategoriaGrid.ItemsSource = kategoriaRepozytorium.GetAll();
            KolorGrid.ItemsSource = koloryRepozytorium.GetAll();
            MarkaGrid.ItemsSource = markaRepozytorium.GetAll();

            DodajKategorieBtn.Click += new RoutedEventHandler(DodajKategorieBtn_Click);
            ZaktualizujKategorieBtn.Click += new RoutedEventHandler(AktualizujKategorieBtn_Click);
            UsunKategorieBtn.Click += new RoutedEventHandler(UsunKategorieBtn_Click);

            DodajKolorBtn.Click += new RoutedEventHandler(DodajKolorBtn_Click);
            ZaktualizujKolorBtn.Click += new RoutedEventHandler(ZaktualizujKolorBtn_Click);
            UsunKolorBtn.Click += new RoutedEventHandler(UsunKolorBtn_Click);

            DodajMarkeBtn.Click += new RoutedEventHandler(DodajMarkeBtn_Click);
            ZaktualizujMarkeBtn.Click += new RoutedEventHandler(ZaktualizujMarkeBtn_Click);
            UsunMarkeBtn.Click += new RoutedEventHandler(UsunMarkeBtn_Click);
        }

        private void DodajKategorieBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = KategoriaGrid.SelectedItem;
            kategoriaRepozytorium.Add(item);
            KategoriaGrid.ItemsSource = kategoriaRepozytorium.GetAll();
            MessageBox.Show("Dodane");
        }

        private void AktualizujKategorieBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = KategoriaGrid.SelectedItem;
            kategoriaRepozytorium.Update(item);
            KategoriaGrid.ItemsSource = kategoriaRepozytorium.GetAll();
            MessageBox.Show("Zaktualizowane");
        }

        private void UsunKategorieBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = (Kategoria)KategoriaGrid.SelectedItem;
            kategoriaRepozytorium.Remove(item.Id);
            KategoriaGrid.ItemsSource = kategoriaRepozytorium.GetAll();
            MessageBox.Show("Usuniete");
        }

        private void DodajKolorBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = KolorGrid.SelectedItem;
            koloryRepozytorium.Add(item);
            KolorGrid.ItemsSource = koloryRepozytorium.GetAll();
            MessageBox.Show("Dodane");
        }

        private void ZaktualizujKolorBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = KolorGrid.SelectedItem;
            koloryRepozytorium.Update(item);
            KolorGrid.ItemsSource = koloryRepozytorium.GetAll();
            MessageBox.Show("Zaktualizowane");
        }

        private void UsunKolorBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = (Kolor)KolorGrid.SelectedItem;
            koloryRepozytorium.Remove(item.Id);
            KolorGrid.ItemsSource = koloryRepozytorium.GetAll();
            MessageBox.Show("Usuniete");
        }

        private void DodajMarkeBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = MarkaGrid.SelectedItem;
            markaRepozytorium.Add(item);
            MarkaGrid.ItemsSource = markaRepozytorium.GetAll();
            MessageBox.Show("Dodane");

        }

        private void ZaktualizujMarkeBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = MarkaGrid.SelectedItem;
            markaRepozytorium.Update(item);
            MarkaGrid.ItemsSource = markaRepozytorium.GetAll();
            MessageBox.Show("Zaktualizowane");
        }

        private void UsunMarkeBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = (Marka)MarkaGrid.SelectedItem;
            markaRepozytorium.Remove(item.Id);
            MarkaGrid.ItemsSource = markaRepozytorium.GetAll();
            MessageBox.Show("Usuniete");
        }
    }
}


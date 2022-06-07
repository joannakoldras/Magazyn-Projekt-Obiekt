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
using UserInterface.Walidatory;

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

            OdswiezGridyBtn.Click += new RoutedEventHandler(OdswiezWszystkieBtn_Click);
        }

        private void DataGrid_OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyName == "Id")
            {
                e.Column.IsReadOnly = true;
            }
        }

        private void DodajKategorieBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = KategoriaGrid.SelectedItem as Kategoria;

            if (item == null)
            {
                MessageBox.Show("Pusty rekord. Wprowadz dane");
            }
            else if (WalidatorNapisu.CzyNapisNieJestPusty(item.NazwaKategorii))
            {
                kategoriaRepozytorium.Add(item);
                KategoriaGrid.ItemsSource = kategoriaRepozytorium.GetAll();
                MessageBox.Show("Dodane");
            }
            else
            {
                MessageBox.Show("Podano bledne dane");
            }
        }

        private void AktualizujKategorieBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = KategoriaGrid.SelectedItem as Kategoria;

            if (item == null)
            {
                MessageBox.Show("Pusty rekord. Wprowadz dane");
            }
            else if (WalidatorNapisu.CzyNapisNieJestPusty(item.NazwaKategorii))
            {
                kategoriaRepozytorium.Update(item);
                KategoriaGrid.ItemsSource = kategoriaRepozytorium.GetAll();
                MessageBox.Show("Zaktualizowane");
            }
            else
            {
                MessageBox.Show("Podano bledne dane");
            }
        }

        private void UsunKategorieBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = KategoriaGrid.SelectedItem as Kategoria;

            if (item == null)
            {
                MessageBox.Show("Pusty rekord. Wprowadz dane");
            }
            else
            {
                kategoriaRepozytorium.Remove(item.Id);
                KategoriaGrid.ItemsSource = kategoriaRepozytorium.GetAll();
                MessageBox.Show("Usuniete");
            }
        }

        private void DodajKolorBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = KolorGrid.SelectedItem as Kolor;

            if (item == null)
            {
                MessageBox.Show("Pusty rekord. Wprowadz dane");
            }
            else if (WalidatorNapisu.CzyNapisNieJestPusty(item.NazwaKoloru))
            {
                koloryRepozytorium.Add(item);
                KolorGrid.ItemsSource = koloryRepozytorium.GetAll();
                MessageBox.Show("Dodane");
            }
            else
            {
                MessageBox.Show("Podano bledne dane");
            }
           
        }

        private void ZaktualizujKolorBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = KolorGrid.SelectedItem as Kolor;

            if (item == null)
            {
                MessageBox.Show("Pusty rekord. Wprowadz dane");
            }
            else if (WalidatorNapisu.CzyNapisNieJestPusty(item.NazwaKoloru))
            {
                koloryRepozytorium.Update(item);
                KolorGrid.ItemsSource = koloryRepozytorium.GetAll();
                MessageBox.Show("Zaktualizowane");
            }
            else
            {
                MessageBox.Show("Podano bledne dane");
            }
        }

        private void UsunKolorBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = KolorGrid.SelectedItem as Kolor;

            if (item == null)
            {
                MessageBox.Show("Pusty rekord. Wprowadz dane");
            }
            else
            {
                koloryRepozytorium.Remove(item.Id);
                KolorGrid.ItemsSource = koloryRepozytorium.GetAll();
                MessageBox.Show("Usuniete");
            }
        }

        private void DodajMarkeBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = MarkaGrid.SelectedItem as Marka;

            if (item == null)
            {
                MessageBox.Show("Pusty rekord. Wprowadz dane");
            }
            else if (WalidatorNapisu.CzyNapisNieJestPusty(item.NazwaMarki))
            {
                markaRepozytorium.Add(item);
                MarkaGrid.ItemsSource = markaRepozytorium.GetAll();
                MessageBox.Show("Dodane");
            }
            else
            {
                MessageBox.Show("Podano bledne dane");
            }
        }

        private void ZaktualizujMarkeBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = MarkaGrid.SelectedItem as Marka;

            if (item == null)
            {
                MessageBox.Show("Pusty rekord. Wprowadz dane");
            }
            else if (WalidatorNapisu.CzyNapisNieJestPusty(item.NazwaMarki))
            {
                markaRepozytorium.Update(item);
                MarkaGrid.ItemsSource = markaRepozytorium.GetAll();
                MessageBox.Show("Zaktualizowane");
            }
            else
            {
                MessageBox.Show("Podano bledne dane");
            }
        }

        private void UsunMarkeBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = MarkaGrid.SelectedItem as Marka;

            if (item == null)
            {
                MessageBox.Show("Pusty rekord. Wprowadz dane");
            }
            else
            {
                markaRepozytorium.Remove(item.Id);
                MarkaGrid.ItemsSource = markaRepozytorium.GetAll();
                MessageBox.Show("Usuniete");
            }
        }

        private void OdswiezWszystkieBtn_Click(object sender, RoutedEventArgs e)
        {
            MarkaGrid.ItemsSource = markaRepozytorium.GetAll();
            KolorGrid.ItemsSource = koloryRepozytorium.GetAll();
            KategoriaGrid.ItemsSource = kategoriaRepozytorium.GetAll();
            MessageBox.Show("Odswiezono");
        }
    }
}



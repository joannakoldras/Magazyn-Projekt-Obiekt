using Backend_CRUD.Repozytorium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserInterface.Walidatory
{
    public static class WalidatorParametruUbran
    {
        private static KolorRepozytorium koloryRepozytorium;
        private static MarkaRepozytrium markaRepozytorium;
        private static KategoriaRepozytrium kategoriaRepozytorium;

        static WalidatorParametruUbran()
        {
            koloryRepozytorium = new KolorRepozytorium();
            markaRepozytorium = new MarkaRepozytrium();
            kategoriaRepozytorium = new KategoriaRepozytrium();
        }

        public static bool CzyIdKategoriiNieJestSpozaZakresu(int value)
        {
            var wynik = kategoriaRepozytorium.GetById(value);
            if (wynik != null)
            {
                return true;
            }
            return false;
        }

        public static bool CzyIdKoloruNieJestSpozaZakresu(int value)
        {
            var wynik = koloryRepozytorium.GetById(value);
            if (wynik != null)
            {
                return true;
            }
            return false;
        }

        public static bool CzyIdMarkiNieJestSpozaZakresu(int value)
        {
            var wynik = markaRepozytorium.GetById(value);
            if (wynik != null)
            {
                return true;
            }
            return false;
        }
    }
}

using Backend_CRUD.Repozytorium;
using System;

namespace Backend_CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            KolorRepozytorium kolorRepozytorium = new KolorRepozytorium();
            var wynik = kolorRepozytorium.GetById(1);
            KategoriaRepozytrium kategoriaRepozytrium = new KategoriaRepozytrium();
            var wynik2 = kategoriaRepozytrium.GetAll();
            var wynik3 = kategoriaRepozytrium.GetById(1);
        }
    }
}

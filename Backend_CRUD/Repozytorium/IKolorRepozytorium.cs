using Backend_CRUD.DB_Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_CRUD.Repozytorium
{
    public interface IKolorRepozytorium
    {
        Kolor GetById(int id);
        IEnumerable<Kolor> GetAll();
        void Add(object color);
        void Remove(int colorId);
        void Update(object color);
    }
}

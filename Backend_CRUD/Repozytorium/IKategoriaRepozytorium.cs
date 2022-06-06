using Backend_CRUD.DB_Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_CRUD.Repozytorium
{
    public interface IKategoriaRepozytorium
    {
        Kategoria GetById(int id);
        IEnumerable<Kategoria> GetAll();
        void Add(object category);
        void Remove(int categoryId);
        void Update(object category);
    }
}

using Backend_CRUD.DB_Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_CRUD.Repozytorium
{
    public interface IUbranieRepozytorium
    {
        Ubranie GetById(int id);
        IEnumerable<Ubranie> GetAll();
        void Add(object clothes);
        void Remove(int clotheId);
        void Update(object clothes);
    }
}

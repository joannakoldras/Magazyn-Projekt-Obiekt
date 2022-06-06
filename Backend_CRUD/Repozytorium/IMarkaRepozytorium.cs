using Backend_CRUD.DB_Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend_CRUD.Repozytorium
{
    public interface IMarkaRepozytorium
    {
        Marka GetById(int id);
        IEnumerable<Marka> GetAll();
        void Add(object brand);
        void Remove(int brandId);
        void Update(object brand);
    }
}

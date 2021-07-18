using System;
using System.Collections.Generic;
using VF.Store.Domain.Entities;

namespace VF.Store.Domain.Contracts.Repositorios
{
    public interface IRepositorio<T> : IDisposable where T : Entity
    {
        IEnumerable<T> Get();
        T Get(int id);
        void Add(T entidade);
        void Edit(T entidade);
        void Delete(T entidade);
    }
}

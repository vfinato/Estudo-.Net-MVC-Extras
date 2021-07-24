using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using VF.Store.Domain.Contracts.Repositorios;
using VF.Store.Domain.Entities;

namespace VF.Store.Data.EF.Repositorios
{
    public class RepositorioEF<T> : IRepositorio<T> where T : Entity
    {
        protected readonly VFStoreDataContextEF _ctx;

        public RepositorioEF(VFStoreDataContextEF ctx)
        {
            _ctx = ctx;
        }

        private void Save()
        {
            _ctx.SaveChanges();
        }

        public IEnumerable<T> Get()
        {
            return _ctx.Set<T>().ToList();
        }

        public T Get(int id)
        {
            return _ctx.Set<T>().Find(id);
        }

        public void Add(T entidade)
        {
            _ctx.Set<T>().Add(entidade);
            Save();
        }

        public void Edit(T entidade)
        {
            _ctx.Entry(entidade).State = EntityState.Modified;
            Save();
        }

        public void Delete(T entidade)
        {
            _ctx.Set<T>().Remove(entidade);
            Save();
        }

        public void Dispose()
        {
        }
    }
}

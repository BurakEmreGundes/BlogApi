using Core.DataAccess;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.InMemory
{
    public class InMemoryEntityRepositoryBase<T> : IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> _items;

        public InMemoryEntityRepositoryBase(List<T> items)
        {
            _items = items;
        }
        public void Add(T entity)
        {
            _items.Add(entity);   
        }

        public void Delete(T entity)
        {
            T itemForDelete = _items.SingleOrDefault();
            _items.Remove(itemForDelete);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter=null)
        {
            return _items;
        }

        public void Update(T entity)
        {
            T itemForUpdate = _items.SingleOrDefault();
            _items.Remove(itemForUpdate);
        }
    }
}

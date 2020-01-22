using System.Collections.Generic;
using System.Linq;
using TestDomain.Domain.Contracts.Repositories;
using TestDomain.Persistencia.Data;

namespace TestDomain.Persistencia.Repositories
{
    public class Base<T> : IBase<T> where T : class
    {
        public Context _context;

        public Base(Context context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var x = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(x);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public ICollection<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T obj)
        {
            _context.Set<T>().Add(obj);
        }

        public void Update(T obj)
        {
            _context.Entry(obj).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
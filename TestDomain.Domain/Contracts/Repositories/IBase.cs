using System.Collections.Generic;

namespace TestDomain.Domain.Contracts.Repositories
{
    public interface IBase<T> where T : class
    {
        ICollection<T> GetAll();

        T GetById(int id);

        void Insert(T obj);

        void Delete(int id);

        void Update(T obj);

        void Commit();

        void Dispose();
    }
}

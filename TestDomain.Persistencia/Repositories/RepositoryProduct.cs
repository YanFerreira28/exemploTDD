using TestDomain.Domain.Entities;
using TestDomain.Persistencia.Data;

namespace TestDomain.Persistencia.Repositories
{
    public class RepositoryProduct : Base<Product>
    {
        public Context _dataContext;

        public RepositoryProduct(Context context) : base(context)
        {
            _dataContext = context;
        }
    }
}
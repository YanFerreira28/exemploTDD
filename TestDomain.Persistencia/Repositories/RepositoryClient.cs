using TestDomain.Domain.Entities;
using TestDomain.Persistencia.Data;

namespace TestDomain.Persistencia.Repositories
{
    public class RepositoryClient : Base<Client>
    {
        public Context _data;

        public RepositoryClient(Context context) : base(context)
        {
            _data = context;
        }
    }
}
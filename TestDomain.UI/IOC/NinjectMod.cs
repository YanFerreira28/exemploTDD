using Ninject.Modules;
using TestDomain.Domain.Contracts.Repositories;
using TestDomain.Persistencia.Repositories;

namespace TestDomain.UI.IOC
{
    public class NinjectMod : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IBase<>)).To(typeof(Base<>));
            Bind(typeof(IProduct)).To(typeof(RepositoryProduct));
            Bind(typeof(IClient)).To(typeof(RepositoryClient));
        }
    }
}
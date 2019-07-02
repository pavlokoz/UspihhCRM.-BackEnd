using Unity;
using Uspihh.UnitOfWork.UnitOfWork;

namespace Uspihh.Unity
{
    public class TypeResolver
    {
        public static void Register(UnityContainer container)
        {
            container.RegisterType<IUnitOfWorkFactory, UnitOfWorkFactory>();
        }
    }
}
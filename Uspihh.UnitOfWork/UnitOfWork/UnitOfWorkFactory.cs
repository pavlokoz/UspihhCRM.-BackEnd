using Uspihh.EF.Context;

namespace Uspihh.UnitOfWork.UnitOfWork
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        public IUnitOfWork CreateUnitOfWork()
        {
            return new UnitOfWork(new UspihhContext());
        }
    }
}

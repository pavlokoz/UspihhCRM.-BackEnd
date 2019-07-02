using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uspihh.EF.Context;

namespace Uspihh.UnitOfWork.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected UspihhContext Context { get; }

        public UnitOfWork(UspihhContext context)
        {
            Context = context;
        }

        //private IRepository<ExampleEntity> exampleRepository;

        //public IRepository<ExampleEntity> ExampleRepository => exampleRepository ??
        //   (exampleRepository = new Repository<ExampleEntity>(Context));

        public void Save()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            if (Context != null)
            {
                Context.Dispose();
            }
        }
    }
}

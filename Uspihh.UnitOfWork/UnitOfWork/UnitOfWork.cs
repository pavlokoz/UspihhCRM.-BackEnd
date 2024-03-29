﻿using Uspihh.EF.Context;
using Uspihh.Models.EntityModels;
using Uspihh.UnitOfWork.Repository;

namespace Uspihh.UnitOfWork.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected UspihhContext Context { get; }

        public UnitOfWork(UspihhContext context)
        {
            Context = context;
        }

        private IRepository<TestEntity> testRepository;

        public IRepository<TestEntity> TestRepository => testRepository ??
           (testRepository = new Repository<TestEntity>(Context));

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

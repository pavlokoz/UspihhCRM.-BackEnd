using System.Collections.Generic;
using System.Linq;
using Uspihh.Models.EntityModels;
using Uspihh.UnitOfWork.UnitOfWork;

namespace Uspihh.Services.Services.Impl
{
    public class TestService : ITestService
    {
        private readonly IUnitOfWorkFactory unitOfWorkFactory;

        public TestService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            this.unitOfWorkFactory = unitOfWorkFactory;
        }

        public IList<TestEntity> GetAll()
        {
            //using (var uow = unitOfWorkFactory.CreateUnitOfWork())
            //{
            //    return uow.TestRepository.Get().ToList();
            //}

        }
    }
}

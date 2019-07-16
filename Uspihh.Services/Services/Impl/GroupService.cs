using System.Collections.Generic;
using System.Linq;
using Uspihh.Models.EntityModels;
using Uspihh.UnitOfWork.UnitOfWork;

namespace Uspihh.Services.Services.Impl
{
    public class GroupService : IGroupService
    {
        private readonly IUnitOfWorkFactory unitOfWorkFactory;

        public GroupService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            this.unitOfWorkFactory = unitOfWorkFactory;
        }

        public GroupEntity GetById(long id)
        {
            using (var uow = unitOfWorkFactory.CreateUnitOfWork())
            {
                return uow.GroupRepository.GetByID(id);
            }
        }

        public IList<GroupEntity> GetAll()
        {
            using (var uow = unitOfWorkFactory.CreateUnitOfWork())
            {
                return uow.GroupRepository.Get().ToList();
            }
        }

        public void CreateGroup(GroupEntity group)
        {
            using (var uow = unitOfWorkFactory.CreateUnitOfWork())
            {
                uow.GroupRepository.Insert(group);
                uow.Save();
            }
        }
    }
}

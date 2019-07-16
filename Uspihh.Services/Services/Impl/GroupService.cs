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

        public void Create(GroupEntity group)
        {
            using (var uow = unitOfWorkFactory.CreateUnitOfWork())
            {
                uow.GroupRepository.Insert(group);
                uow.Save();
            }
        }

        public void Delete(GroupEntity entity)
        {
            using (var uow = unitOfWorkFactory.CreateUnitOfWork())
            {
                uow.GroupRepository.Delete(entity);
                uow.Save();
            }
        }
    }
}

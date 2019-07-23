using System;
using System.Collections.Generic;
using System.Linq;
using Uspihh.Models.EntityModels;
using Uspihh.UnitOfWork.UnitOfWork;

namespace Uspihh.Services.Services.Impl
{
    public class TeacherService : ITeacherService
    {
        private readonly IUnitOfWorkFactory unitOfWorkFactory;

        public TeacherService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            this.unitOfWorkFactory = unitOfWorkFactory;
        }

        public void Create(TeacherEntity entity)
        {
            using (var uow = unitOfWorkFactory.CreateUnitOfWork())
            {
                uow.TeacherRepository.Insert(entity);
                uow.Save();
            }
        }

        public void Delete(TeacherEntity entity)
        {
            using (var uow = unitOfWorkFactory.CreateUnitOfWork())
            {
                uow.TeacherRepository.Delete(entity);
                uow.Save();
            }
        }

        public IList<TeacherEntity> GetAll()
        {
            using (var uow = unitOfWorkFactory.CreateUnitOfWork())
            {
                var teachers = uow.TeacherRepository.Get().ToList();
                return teachers;
            }
        }

        public TeacherEntity GetById(long id)
        {
            using (var uow = unitOfWorkFactory.CreateUnitOfWork())
            {
                var teacher = uow.TeacherRepository.GetByID(id);
                return teacher;
            }
        }
    }
}

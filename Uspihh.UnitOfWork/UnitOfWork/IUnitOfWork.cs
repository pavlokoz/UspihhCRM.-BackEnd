using System;
using Uspihh.Models.EntityModels;
using Uspihh.UnitOfWork.Repository;

namespace Uspihh.UnitOfWork.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
        IRepository<TestEntity> TestRepository { get; }
        IRepository<GroupEntity> GroupRepository { get; }
        IRepository<StudentEntity> StudentRepository { get; }
    }
}

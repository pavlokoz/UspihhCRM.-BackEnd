using Uspihh.EF.Context;
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
        private IRepository<GroupEntity> groupRepository;
        private IRepository<StudentEntity> studentRepository;
        private IRepository<SubjectEntity> subjectRepository;
        private IRepository<GroupStudentEntity> groupStudentRepository;
        private IRepository<GroupTeacherEntity> groupTeacherRepository;
        private IRepository<TeacherEntity> teacherRepository;
        private IRepository<UserEntity> userRepository;

        public IRepository<TestEntity> TestRepository => testRepository ??
           (testRepository = new Repository<TestEntity>(Context));


        public IRepository<GroupEntity> GroupRepository => groupRepository ??
            (groupRepository = new Repository<GroupEntity>(Context));

        public IRepository<StudentEntity> StudentRepository => studentRepository ??
           (studentRepository = new Repository<StudentEntity>(Context));

        public IRepository<SubjectEntity> SubjectRepository => subjectRepository ?? 
            (subjectRepository = new Repository<SubjectEntity>(Context));

        public IRepository<GroupStudentEntity> GroupStudentRepository => groupStudentRepository ?? 
            (groupStudentRepository = new Repository<GroupStudentEntity>(Context));

        public IRepository<GroupTeacherEntity> GroupTeacherRepository => groupTeacherRepository ??
            (groupTeacherRepository = new Repository<GroupTeacherEntity>(Context));

        public IRepository<TeacherEntity> TeacherRepository => teacherRepository ??
            (teacherRepository = new Repository<TeacherEntity>(Context));

        public IRepository<UserEntity> UserRepository => userRepository ??
            (userRepository = new Repository<UserEntity>(Context));

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

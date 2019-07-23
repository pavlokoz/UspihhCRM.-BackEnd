using Uspihh.Models.EntityModels;
using Uspihh.UnitOfWork.UnitOfWork;

namespace Uspihh.Services.Services.Impl
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWorkFactory unitOfWorkFactory;

        public StudentService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            this.unitOfWorkFactory = unitOfWorkFactory;
        }

        public void CreateStudent(StudentEntity student, long groupId)
        {
            using (var uow = unitOfWorkFactory.CreateUnitOfWork())
            {
                uow.StudentRepository.Insert(student);
                var groupStudent = new GroupStudentEntity()
                {
                    GroupId = groupId,
                    StudentId = student.StudentId
                };
                uow.GroupStudentRepository.Insert(groupStudent);
                uow.Save();
            }
        }

        public StudentEntity GetStudentById(long studentId)
        {
            using (var uow = unitOfWorkFactory.CreateUnitOfWork())
            {
                var student = uow.StudentRepository.GetByID(studentId);
                return student;
            }
        }
    }
}

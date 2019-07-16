using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void CreateStudent(StudentEntity student)
        {
            using (var uow = unitOfWorkFactory.CreateUnitOfWork())
            {
                uow.StudentRepository.Insert(student);
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

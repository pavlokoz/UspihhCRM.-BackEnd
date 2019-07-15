using Uspihh.Models.EntityModels;

namespace Uspihh.Services.Services
{
    public interface IStudentService
    {
        void CreateStudent(StudentEntity student);
        StudentEntity GetStudentById(long studentId);
    }
}

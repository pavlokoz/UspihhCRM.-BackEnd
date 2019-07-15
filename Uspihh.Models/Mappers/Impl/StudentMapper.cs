using Uspihh.Models.DTOModels;
using Uspihh.Models.EntityModels;

namespace Uspihh.Models.Mappers.Impl
{
    public class StudentMapper : IMapper<StudentEntity, StudentDTO>
    {
        public StudentEntity Map(StudentDTO source)
        {
            return new StudentEntity
            {
                StudentId = source.StudentId,
                DateOfBirth = source.DateOfBirth,
                Email = source.Email,
                FirstName = source.FirstName,
                LastName = source.LastName,
                PhoneNumber = source.PhoneNumber
            };

        }

        public StudentDTO Map(StudentEntity source)
        {
            return new StudentDTO
            {
                StudentId = source.StudentId,
                DateOfBirth = source.DateOfBirth,
                Email = source.Email,
                FirstName = source.FirstName,
                LastName = source.LastName,
                PhoneNumber = source.PhoneNumber
            };
        }
    }
}

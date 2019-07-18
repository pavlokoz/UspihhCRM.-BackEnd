using Uspihh.Models.DTOModels;
using Uspihh.Models.EntityModels;

namespace Uspihh.Models.Mappers.Impl
{
    public class TeacherMapper : IMapper<TeacherEntity, TeacherDTO>
    {
        public TeacherEntity Map(TeacherDTO source)
        {
            throw new System.NotImplementedException();
        }

        public TeacherDTO Map(TeacherEntity source)
        {
            return new TeacherDTO
            {
                TeacherId = source.TeacherId,
                DateOfBirth = source.User?.DateOfBirth,
                Email = source.User?.Email,
                FirstName = source.User?.FirstName,
                LastName = source.User?.LastName
            };
        }
    }
}

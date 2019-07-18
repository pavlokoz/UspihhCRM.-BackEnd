using System.Linq;
using Uspihh.Models.DTOModels;
using Uspihh.Models.EntityModels;

namespace Uspihh.Models.Mappers.Impl
{
    public class GroupDetailMapper : IMapper<GroupEntity, GroupDetailDTO>
    {
        private readonly IMapper<StudentEntity, StudentDTO> mapperStudent;

        public GroupDetailMapper(IMapper<StudentEntity, StudentDTO> mapperStudent)
        {
            this.mapperStudent = mapperStudent;
        }

        public GroupEntity Map(GroupDetailDTO source)
        {
            return new GroupEntity
            {
                GroupId = source.GroupId,
                GroupName = source.GroupName,
                StartDate = source.StartDate,
                EndDate = source.EndDate,
                MaxCountOfStudents = source.MaxCountOfStudent,
                MonthPrice = source.MonthPrice,
                SubjectId = source.SubjectId,
                Students = source.Students.Select(mapperStudent.Map).ToList()           
            };
        }

        public GroupDetailDTO Map(GroupEntity source)
        {
            return new GroupDetailDTO
            {
                GroupId = source.GroupId,
                GroupName = source.GroupName,
                StartDate = source.StartDate,
                EndDate = source.EndDate,
                MaxCountOfStudent = source.MaxCountOfStudents,
                MonthPrice = source.MonthPrice,
                SubjectId = source.SubjectId,
                Students = source.Students.Select(mapperStudent.Map).ToList(),
                SubjectName = source.Subject.SubjectName
            };
        }
    }
}

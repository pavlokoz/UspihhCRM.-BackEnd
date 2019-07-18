using Uspihh.Models.DTOModels;
using Uspihh.Models.EntityModels;

namespace Uspihh.Models.Mappers.Impl
{
    public class GroupDetailMapper : IMapper<GroupEntity, GroupDetailDTO>
    {
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
                Students = source.Students,
                GroupStudents = source.GroupStudents
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
                Students = source.Students,
                GroupStudents = source.GroupStudents
            };
        }
    }
}

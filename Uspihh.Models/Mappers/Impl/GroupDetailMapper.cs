using System.Linq;
using Uspihh.Models.DTOModels;
using Uspihh.Models.EntityModels;

namespace Uspihh.Models.Mappers.Impl
{
    public class GroupDetailMapper : IMapper<GroupEntity, GroupDetailDTO>
    {
        private readonly IMapper<StudentEntity, StudentDTO> studentMapper;
        private readonly IMapper<TeacherEntity, TeacherDTO> teacherMapper;

        public GroupDetailMapper(IMapper<StudentEntity, StudentDTO> studentMapper,
            IMapper<TeacherEntity, TeacherDTO> teacherMapper)
        {
            this.studentMapper = studentMapper;
            this.teacherMapper = teacherMapper;
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
                Students = source.Students.Select(studentMapper.Map).ToList(),
                Teachers = source.Teachers.Select(teacherMapper.Map).ToList()
                
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
                SubjectName = source.Subject.SubjectName,
                Students = source.Students.Select(studentMapper.Map).ToList(),
                Teachers = source.Teachers.Select(teacherMapper.Map).ToList()
            };
        }
    }
}

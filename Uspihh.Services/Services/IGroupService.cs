using Uspihh.Models.EntityModels;

namespace Uspihh.Services.Services
{
    public interface IGroupService : IService<GroupEntity>
    {
        void AddExistingStudentToGroup(long studentId, long groupId);
        void AddExistingTeacherToGroup(int teacherId, long groupId);
    }
}

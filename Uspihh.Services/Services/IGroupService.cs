using System.Collections.Generic;
using System.Threading.Tasks;
using Uspihh.Models.DTOModels;
using Uspihh.Models.EntityModels;

namespace Uspihh.Services.Services
{
    public interface IGroupService : IService<GroupEntity>
    {
        void AddExistingStudentToGroup(long studentId, long groupId);
    }
}

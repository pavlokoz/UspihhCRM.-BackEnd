using System.Collections.Generic;
using Uspihh.Models.EntityModels;

namespace Uspihh.Models.DTOModels
{
    public class GroupDetailDTO : GroupDTO
    {
        public IList<StudentEntity> Students { get; set; }
        public IList<GroupStudentEntity> GroupStudents { get; set; }
    }
}

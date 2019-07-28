using System.Collections.Generic;

namespace Uspihh.Models.EntityModels
{
    public class TeacherEntity
    {
        public int TeacherId { get; set; }
        public byte[] CV { get; set; }

        public UserEntity User { get; set; }

        public IList<GroupEntity> Groups { get; set; }
        public IList<GroupTeacherEntity> GroupTeachers { get; set; }
    }
}

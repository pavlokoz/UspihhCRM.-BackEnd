using System;
using System.Collections.Generic;

namespace Uspihh.Models.EntityModels
{
    public class GroupEntity
    {
        public long GroupId { get; set; }
        public string GroupName { get; set; }
        public short MaxCountOfStudents { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MonthPrice { get; set; }
        public SubjectEntity Subject { get; set; }
        public short SubjectId { get; set; }

        public IList<StudentEntity> Students { get; set; }
        public IList<GroupStudentEntity> GroupStudents { get; set; }

        public IList<TeacherEntity> Teachers { get; set; }
        public IList<GroupTeacherEntity> GroupTeachers { get; set; }
    }
}

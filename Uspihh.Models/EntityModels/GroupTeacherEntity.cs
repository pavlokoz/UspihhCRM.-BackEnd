namespace Uspihh.Models.EntityModels
{
    public class GroupTeacherEntity
    {
        public long GroupId { get; set; }
        public int TeacherId { get; set; }

        public GroupEntity Group { get; set; }
        public TeacherEntity Teacher {get; set;}
    }
}

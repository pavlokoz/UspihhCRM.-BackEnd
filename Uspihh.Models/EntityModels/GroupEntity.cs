using System;

namespace Uspihh.Models.EntityModels
{
    public class GroupEntity
    {
        public long GroupId { get; set; }
        public string GroupName { get; set; }
        public short MaxCountOfStudent { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MounthPrice { get; set; }
        public SubjectEntity Subject { get; set; }
        public long SubjectId { get; set; }
    }
}

using System.Collections.Generic;

namespace Uspihh.Models.EntityModels
{
    public class SubjectEntity
    {
        public long SubjectId { get; set; }
        public string SubjectName { get; set; }
        public IList<GroupEntity> Groups { get; set; }
    }
}


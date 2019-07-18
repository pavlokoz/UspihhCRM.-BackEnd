using System.Collections.Generic;

namespace Uspihh.Models.EntityModels
{
    public class SubjectEntity
    {
        public short SubjectId { get; set; }
        public string SubjectName { get; set; }
        public IList<GroupEntity> Groups { get; set; }
    }
}


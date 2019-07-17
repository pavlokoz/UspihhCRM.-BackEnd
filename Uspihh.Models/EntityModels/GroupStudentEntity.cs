using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uspihh.Models.EntityModels
{
    public class GroupStudentEntity
    {
        public long StudentId { get; set; }
        public long GroupId { get; set; }

        public StudentEntity Student { get; set; }
        public GroupEntity Group { get; set; }
    }
}

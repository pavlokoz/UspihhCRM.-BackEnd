using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uspihh.Models.DTOModels
{
    public class GroupDTO
    {
        public long GroupId { get; set; }
        public string GroupName { get; set; }
        public int MaxCountOfStudent { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MounthPrice { get; set; }
        public long SubjectId { get; set; }
    }
}

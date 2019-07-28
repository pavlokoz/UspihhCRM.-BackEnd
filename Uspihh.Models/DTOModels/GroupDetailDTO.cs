using System.Collections.Generic;

namespace Uspihh.Models.DTOModels
{
    public class GroupDetailDTO : GroupDTO
    {
        public IList<StudentDTO> Students { get; set; }
        public IList<TeacherDTO> Teachers { get; set; }

    }
}

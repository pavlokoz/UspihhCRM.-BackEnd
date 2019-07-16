﻿using Uspihh.Models.DTOModels;
using Uspihh.Models.EntityModels;

namespace Uspihh.Models.Mappers.Impl
{
    public class GroupMapper : IMapper<GroupEntity, GroupDTO>
    {
        public GroupEntity Map(GroupDTO source)
        {
            return new GroupEntity
            {
                GroupId = source.GroupId,
                StartDate = source.StartDate,
                EndDate = source.EndDate,
                GroupName = source.GroupName,
                MaxCountOfStudent = source.MaxCountOfStudent,
                MounthPrice = source.MounthPrice,
                SubjectId = source.SubjectId
            };
        }

        public GroupDTO Map(GroupEntity source)
        {
            return new GroupDTO
            {
                GroupId = source.GroupId,
                StartDate = source.StartDate,
                EndDate = source.EndDate,
                GroupName = source.GroupName,
                MaxCountOfStudent = source.MaxCountOfStudent,
                MounthPrice = source.MounthPrice,
                SubjectId = source.SubjectId             
            };
        }
    }
}

﻿using System;

namespace Uspihh.Models.DTOModels
{
    public class GroupDTO
    {
        public long GroupId { get; set; }
        public string GroupName { get; set; }
        public short MaxCountOfStudent { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MonthPrice { get; set; }
        public short SubjectId { get; set; }
        public string SubjectName { get; set; }
    }
}

using LeaveApp.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveApp.Dal.ViewModels
{
    public class LeaveDto
    {
        public int Id { get; set; }
        public string LeaveType { get; set; }
        public string Description { get; set; }
        public string SpecialLeave { get; set; }
        public int TotalDays { get; set; }

        public LeaveDto()
        {

        } 
        public LeaveDto(Leave leave)
        {
            Id = leave.Id;
            LeaveType = leave.LeaveType;
            Description = leave.Description;
            SpecialLeave = leave.SpecialLeave;
        }
    }
}

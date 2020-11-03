using LeaveApp.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveApp.Dal.ViewModels
{
    public class UserLeaveDto
    {
        public int UserId { get; set; }
        public int LeaveId { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public string ApprovedBy { get; set; }
        public bool IsAproved { get; set; }
        public string UserReplacment { get; set; }

        public UserLeaveDto()
        {

        }
        public UserLeaveDto(UserLeave UsrL)
        {
            UserId = UsrL.UserId;
            LeaveId = UsrL.LeaveId;
            StartingDate = UsrL.StartingDate;
            EndingDate = UsrL.EndingDate;
            IsAproved = UsrL.IsAproved;
            UserReplacment = UsrL.UserReplacment;
        }
    }
}

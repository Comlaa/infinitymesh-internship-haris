using LeaveApp.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeaveApp.Dal.ViewModels
{
    public class LeaveViewModel
    {
        public IReadOnlyCollection<LeaveDto> Collection { get; }

        public LeaveViewModel(IReadOnlyCollection<Leave> Leaves)
        {
            Collection = Leaves.Select(leave => new LeaveDto(leave)).ToList();

        }
    }
}

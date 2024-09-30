using System.ComponentModel.DataAnnotations;

namespace LeaveManSystem.Models.LeaveTypes
{
    public class LeaveTypeReadOnlyVM : BaseLeaveTypeVM
    {
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Maximum Allocation of Days")]
        public int NumberofDays { get; set; }
    }
}

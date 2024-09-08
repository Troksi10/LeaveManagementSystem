using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManSystem.Data
{
    public class LeaveType
    {
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string Name { get; set; }
        public int NumberofDays { get; set; }

    }
}

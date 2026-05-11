using System;
using System.Collections.Generic;

namespace Final_Project_Dinalo_Maglasang.Models;

public partial class Schedule
{
    public int ScheduleId { get; set; }

    public int? SubjectId { get; set; }

    public string? DayGroup { get; set; }

    public TimeSpan? TimeStart { get; set; }

    public TimeSpan? EndTime { get; set; }

    public int? InstructorId { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual Instructor? Instructor { get; set; }

    public virtual Subject? Subject { get; set; }
}

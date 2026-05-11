using System;
using System.Collections.Generic;

namespace Final_Project_Dinalo_Maglasang.Models;

public partial class Enrollment
{
    public int EnrollmentId { get; set; }

    public int? StudentId { get; set; }

    public int? ScheduleId { get; set; }

    public int? InstructorId { get; set; }

    public DateTime? DateEnrolled { get; set; }

    public string? Status { get; set; }

    public virtual Instructor? Instructor { get; set; }

    public virtual Schedule? Schedule { get; set; }

    public virtual Student? Student { get; set; }
}

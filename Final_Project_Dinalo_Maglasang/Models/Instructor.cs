using System;
using System.Collections.Generic;

namespace Final_Project_Dinalo_Maglasang.Models;

public partial class Instructor
{
    public int InstructorId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
}

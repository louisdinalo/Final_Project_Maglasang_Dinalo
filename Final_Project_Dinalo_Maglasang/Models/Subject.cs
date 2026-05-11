using System;
using System.Collections.Generic;

namespace Final_Project_Dinalo_Maglasang.Models;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string? SubjectName { get; set; }

    public string? CourseCode { get; set; }

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
}

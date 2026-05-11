using System;
using System.Collections.Generic;

namespace Final_Project_Dinalo_Maglasang.Models;

public partial class Grade
{
    public int GradeId { get; set; }

    public int? SubjectId { get; set; }

    public decimal? GradeValue { get; set; }

    public string? Remark { get; set; }

    public virtual Subject? Subject { get; set; }
}

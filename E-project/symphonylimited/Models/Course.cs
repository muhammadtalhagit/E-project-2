using System;
using System.Collections.Generic;

namespace symphonylimited.Models;

public partial class Course
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string Fees { get; set; } = null!;

    public string Duration { get; set; } = null!;

    public string InstructorName { get; set; } = null!;

    public virtual ICollection<RegisteredStudent> RegisteredStudents { get; set; } = new List<RegisteredStudent>();
}

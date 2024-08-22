using System;
using System.Collections.Generic;

namespace symphonylimited.Models;

public partial class EntranceStudent
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int ExamId { get; set; }

    public int PhoneNo { get; set; }

    public string Result { get; set; } = null!;

    public virtual Exam Exam { get; set; } = null!;
}

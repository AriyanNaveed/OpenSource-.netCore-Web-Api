using System;
using System.Collections.Generic;

namespace StudentCrud.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public string? StudentGender { get; set; }

    public int Age { get; set; }

    public int Standard { get; set; }

    public string FatherName { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }
}

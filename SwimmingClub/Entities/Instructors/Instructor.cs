using System;
namespace SwimmingClub.Entities.Instructors;

public sealed class Instructor : Human
{
    public float Salary { get; set; }

    public string Title { get; set; } = String.Empty;
}

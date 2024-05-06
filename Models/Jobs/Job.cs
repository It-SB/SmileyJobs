using System;
using System.Collections.Generic;

namespace Smile.Models.Jobs;

public partial class Job
{
    public int Id { get; set; }

    public string? Requirements { get; set; }

    public string? CompanyName { get; set; }

    public string? Website { get; set; }

    public string? Email { get; set; }

    public string? EmploymentType { get; set; }

    public string? Description { get; set; }

    public string? Location { get; set; }

    public string? Salary { get; set; }

    public DateTime? PostedDate { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public string? Category { get; set; }

    public string? SkillsRequired { get; set; }

    public string? EducationLevel { get; set; }

    public string? ExperienceLevel { get; set; }
    public bool? isFeatured { get; set; }
}

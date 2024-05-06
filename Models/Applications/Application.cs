using System;
using System.Collections.Generic;

namespace Smile.Models.Applications;

public partial class Application
{
    public string Id { get; set; } = null!;

    public string? UserName { get; set; }

    public string? NormalizedUserName { get; set; }

    public string? Email { get; set; }

    public string? NormalizedEmail { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTimeOffset? LockoutEnd { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public int JobId { get; set; }

    public int ApplicantId { get; set; }

    public string? ResumeCv { get; set; }

    public string? CoverLetter { get; set; }

    public DateTime ApplicationDate { get; set; }

    public string? Status { get; set; }

    public string? CommentsNotes { get; set; }
}

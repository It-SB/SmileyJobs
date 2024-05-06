using System;
using System.Collections.Generic;

namespace Smile.Models.JobListing;

public partial class JobListing
{
    public int AdminId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Role { get; set; } = null!;
}

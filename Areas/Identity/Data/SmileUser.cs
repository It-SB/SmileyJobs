using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Smile.Areas.Identity.Data;

// Add profile data for application users by adding properties to the SmileUser class
public class SmileUser : IdentityUser
{
    public string? Surname { get; set; }

    public string? Name { get; set; }

    public string? Mobile { get; set; }

    public bool TenthGrade { get; set; }

    public bool TwelfthGrade { get; set; }

    public bool PostGraduation { get; set; }

    public bool PhD { get; set; }

    public string? Experience { get; set; }
    public string? CareerField { get; set; }

    public string? Resume { get; set; }

    public string? Address { get; set; }

    public string? Province { get; set; }

    public string? Country { get; set; }
}


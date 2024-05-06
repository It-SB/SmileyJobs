using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Smile.Models.Applications
{
    public class ApplicationSContext : DbContext
    {
        public ApplicationSContext (DbContextOptions<ApplicationSContext> options)
            : base(options)
        {
        }

        public DbSet<Smile.Models.Applications.Application> Application { get; set; } = default!;
    }
}

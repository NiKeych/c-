using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bold.Models;

namespace Bold.Data
{
    public class BoldContext : DbContext
    {
        public BoldContext (DbContextOptions<BoldContext> options)
            : base(options)
        {
        }

        public DbSet<Bold.Models.Movie> Movie { get; set; } = default!;
    }
}

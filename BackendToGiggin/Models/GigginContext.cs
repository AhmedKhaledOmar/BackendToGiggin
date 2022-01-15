using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendToGiggin.Models
{
    public class GigginContext : DbContext
    {
        public GigginContext(DbContextOptions<GigginContext> options)
            : base(options)
        {
        }
        public DbSet<State> States { get; set; }
    }
}

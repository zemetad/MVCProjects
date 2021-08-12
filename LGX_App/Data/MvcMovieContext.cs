using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LGX.Models;

namespace LGX.Data
{
    public class LGXContext : DbContext
    {
        public LGXContext (DbContextOptions<LGXContext> options)
            : base(options)
        {
        }

        public DbSet<LGX.Models.RelayRack> RelayRack { get; set; }

        public DbSet<LGX.Models.Shelf> Shelf { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LGX.Models
{
    public class RelayRack
    {
        public int Id { get; set; }
        public string RackName { get; set; }
        public string Isle { get; set; }

        public string FloorNumber { get; set; }

        public string RackNumber { get; set; }

        public string Comment { get; set; }

        public ICollection<Shelf> Shelves { get; set; }
    }

    public class RelayRackDBContext : DbContext
    {
        public DbSet<RelayRack> RelayRacks { get; set; }

    }
}

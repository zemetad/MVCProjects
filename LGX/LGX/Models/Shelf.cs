using System;
using Microsoft.EntityFrameworkCore;

namespace LGX.Models
{
    public class Shelf
    {
        public int Id { get; set; }
        public string PanelNumber { get; set; }
        public string DeviceType { get; set; }
        public string Comment { get; set; }
    }

    public class ShelfDBContext : DbContext
    {
        public DbSet<Shelf> Shelves { get; set; }

    }
}

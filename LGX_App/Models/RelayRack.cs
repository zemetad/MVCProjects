using System;
using System.ComponentModel.DataAnnotations;

namespace LGX.Models
{
    public class RelayRack
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Isle { get; set; }
        public string RackNumber { get; set; }
        public string Comment { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Location
    {
        public Location()
        {
            Orders = new HashSet<Order>();
            SerialLocationChainNewLocations = new HashSet<SerialLocationChain>();
            SerialLocationChainOldLocations = new HashSet<SerialLocationChain>();
            Serials = new HashSet<Serial>();
        }

        public int Id { get; set; }
        public int LocationTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual LocationType LocationType { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<SerialLocationChain> SerialLocationChainNewLocations { get; set; }
        public virtual ICollection<SerialLocationChain> SerialLocationChainOldLocations { get; set; }
        public virtual ICollection<Serial> Serials { get; set; }
    }
}

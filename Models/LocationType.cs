using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class LocationType
    {
        public LocationType()
        {
            Locations = new HashSet<Location>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Location> Locations { get; set; }
    }
}

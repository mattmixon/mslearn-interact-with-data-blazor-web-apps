using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class TrailerLocation
    {
        public TrailerLocation()
        {
            TrailerCurrents = new HashSet<TrailerCurrent>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int AddressId { get; set; }

        public virtual ICollection<TrailerCurrent> TrailerCurrents { get; set; }
    }
}

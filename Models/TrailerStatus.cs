using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class TrailerStatus
    {
        public TrailerStatus()
        {
            TrailerCurrents = new HashSet<TrailerCurrent>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<TrailerCurrent> TrailerCurrents { get; set; }
    }
}

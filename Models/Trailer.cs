using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Trailer
    {
        public Trailer()
        {
            Rmas = new HashSet<Rma>();
            TrailerCurrents = new HashSet<TrailerCurrent>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Rma> Rmas { get; set; }
        public virtual ICollection<TrailerCurrent> TrailerCurrents { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class ObservationType
    {
        public ObservationType()
        {
            Observations = new HashSet<Observation>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Observation> Observations { get; set; }
    }
}

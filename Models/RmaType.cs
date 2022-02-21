using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class RmaType
    {
        public RmaType()
        {
            Rmas = new HashSet<Rma>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Rma> Rmas { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Shipper
    {
        public Shipper()
        {
            Rmas = new HashSet<Rma>();
        }

        public int Id { get; set; }
        public int EntityId { get; set; }

        public virtual Entity Entity { get; set; } = null!;
        public virtual ICollection<Rma> Rmas { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Carrier
    {
        public Carrier()
        {
            Bols = new HashSet<Bol>();
        }

        public int Id { get; set; }
        public int? EntityId { get; set; }

        public virtual ICollection<Bol> Bols { get; set; }
    }
}

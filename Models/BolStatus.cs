using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class BolStatus
    {
        public BolStatus()
        {
            Bols = new HashSet<Bol>();
        }

        public int Id { get; set; }
        public int Name { get; set; }

        public virtual ICollection<Bol> Bols { get; set; }
    }
}

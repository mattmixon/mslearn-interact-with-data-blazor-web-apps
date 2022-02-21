using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            ItemMasters = new HashSet<ItemMaster>();
            ManifestDetails = new HashSet<ManifestDetail>();
        }

        public int Id { get; set; }
        public int EntityId { get; set; }

        public virtual Entity Entity { get; set; } = null!;
        public virtual ICollection<ItemMaster> ItemMasters { get; set; }
        public virtual ICollection<ManifestDetail> ManifestDetails { get; set; }
    }
}

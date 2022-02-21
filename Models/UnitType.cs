using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class UnitType
    {
        public UnitType()
        {
            ItemMasters = new HashSet<ItemMaster>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<ItemMaster> ItemMasters { get; set; }
    }
}

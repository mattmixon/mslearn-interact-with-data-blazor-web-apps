using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class ItemAlt
    {
        public int Int { get; set; }
        public int ItemId { get; set; }
        public int ModelId { get; set; }

        public virtual Item Item { get; set; } = null!;
        public virtual ItemMaster Model { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Item
    {
        public Item()
        {
            ItemAlts = new HashSet<ItemAlt>();
            ItemSerials = new HashSet<ItemSerial>();
        }

        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ModelId { get; set; }
        public short Quantity { get; set; }

        public virtual ItemMaster Model { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
        public virtual ICollection<ItemAlt> ItemAlts { get; set; }
        public virtual ICollection<ItemSerial> ItemSerials { get; set; }
    }
}

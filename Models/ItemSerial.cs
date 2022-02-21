using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class ItemSerial
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int SerialId { get; set; }

        public virtual Item Item { get; set; } = null!;
        public virtual Serial Serial { get; set; } = null!;
    }
}

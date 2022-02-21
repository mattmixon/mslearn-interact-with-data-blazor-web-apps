using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class SerialLocationChain
    {
        public int Id { get; set; }
        public int SerialId { get; set; }
        public int OldLocationId { get; set; }
        public int NewLocationId { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public int UserId { get; set; }

        public virtual Location NewLocation { get; set; } = null!;
        public virtual Location OldLocation { get; set; } = null!;
        public virtual Serial Serial { get; set; } = null!;
        public virtual SerialInventoryProcessChain User { get; set; } = null!;
        public virtual User UserNavigation { get; set; } = null!;
    }
}

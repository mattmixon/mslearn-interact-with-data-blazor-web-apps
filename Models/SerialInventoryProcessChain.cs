using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class SerialInventoryProcessChain
    {
        public SerialInventoryProcessChain()
        {
            SerialLocationChains = new HashSet<SerialLocationChain>();
        }

        public int Id { get; set; }
        public int SerialId { get; set; }
        public int OldInventoryStageId { get; set; }
        public int NewInventoryStageId { get; set; }
        public DateTime DatetimeStamp { get; set; }
        public int UserId { get; set; }

        public virtual ICollection<SerialLocationChain> SerialLocationChains { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class InventoryStage
    {
        public InventoryStage()
        {
            Serials = new HashSet<Serial>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Serial> Serials { get; set; }
    }
}

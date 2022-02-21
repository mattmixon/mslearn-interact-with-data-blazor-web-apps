using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class OriginatingLocation
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? EntityId { get; set; }

        public virtual Entity? Entity { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class EntityAddess
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public int AddressId { get; set; }

        public virtual Address Address { get; set; } = null!;
        public virtual Entity Entity { get; set; } = null!;
    }
}

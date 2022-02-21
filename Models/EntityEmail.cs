using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class EntityEmail
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public int EmailId { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsActive { get; set; }

        public virtual Email Email { get; set; } = null!;
        public virtual Entity Entity { get; set; } = null!;
    }
}

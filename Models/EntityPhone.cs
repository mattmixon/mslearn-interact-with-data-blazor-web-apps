using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class EntityPhone
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public int PhoneId { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsActive { get; set; }

        public virtual Entity Entity { get; set; } = null!;
        public virtual Phone Phone { get; set; } = null!;
    }
}

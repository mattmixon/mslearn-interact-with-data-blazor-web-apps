using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class ConditionValue
    {
        public int Id { get; set; }
        public int ConditionId { get; set; }
        public object Value { get; set; } = null!;

        public virtual Condition Condition { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class ConditionType
    {
        public ConditionType()
        {
            Conditions = new HashSet<Condition>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Condition> Conditions { get; set; }
    }
}

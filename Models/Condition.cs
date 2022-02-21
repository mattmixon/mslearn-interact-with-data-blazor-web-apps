using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Condition
    {
        public Condition()
        {
            ConditionValues = new HashSet<ConditionValue>();
        }

        public int Id { get; set; }
        public int PresentationTreeId { get; set; }
        public int ConditionTypeId { get; set; }
        public int ActionId { get; set; }

        public virtual ActionToDo Action { get; set; } = null!;
        public virtual ConditionType ConditionType { get; set; } = null!;
        public virtual PresentationTree PresentationTree { get; set; } = null!;
        public virtual ICollection<ConditionValue> ConditionValues { get; set; }
    }
}

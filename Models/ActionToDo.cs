using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class ActionToDo
    {
        public ActionToDo()
        {
            ActionToDoValues = new HashSet<ActionToDoValue>();
            Conditions = new HashSet<Condition>();
        }

        public int Id { get; set; }
        public int ConditionId { get; set; }
        public int ActionToDoTypeId { get; set; }
        public int ParentId { get; set; }

        public virtual ActionToDoType ActionToDoType { get; set; } = null!;
        public virtual ICollection<ActionToDoValue> ActionToDoValues { get; set; }
        public virtual ICollection<Condition> Conditions { get; set; }
    }
}

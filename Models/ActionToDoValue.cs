using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class ActionToDoValue
    {
        public int Id { get; set; }
        public int ActionToDoId { get; set; }
        public object Value { get; set; } = null!;

        public virtual ActionToDo ActionToDo { get; set; } = null!;
    }
}

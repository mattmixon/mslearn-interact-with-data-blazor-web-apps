using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class ActionToDoType
    {
        public ActionToDoType()
        {
            ActionToDos = new HashSet<ActionToDo>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<ActionToDo> ActionToDos { get; set; }
    }
}

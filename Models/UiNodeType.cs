using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class UiNodeType
    {
        public UiNodeType()
        {
            PresentationTrees = new HashSet<PresentationTree>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PresentationTree> PresentationTrees { get; set; }
    }
}

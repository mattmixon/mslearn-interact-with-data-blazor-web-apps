using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class DataType
    {
        public DataType()
        {
            PresentationTrees = new HashSet<PresentationTree>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<PresentationTree> PresentationTrees { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class RemanFunction
    {
        public RemanFunction()
        {
            PresentationTrees = new HashSet<PresentationTree>();
            Stations = new HashSet<Station>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PresentationTree> PresentationTrees { get; set; }
        public virtual ICollection<Station> Stations { get; set; }
    }
}

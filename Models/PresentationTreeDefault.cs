using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class PresentationTreeDefault
    {
        public int Id { get; set; }
        public int PresentationTreeId { get; set; }
        public object Value { get; set; } = null!;

        public virtual PresentationTree PresentationTree { get; set; } = null!;
    }
}

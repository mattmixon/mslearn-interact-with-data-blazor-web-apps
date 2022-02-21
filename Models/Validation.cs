using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Validation
    {
        public Validation()
        {
            ValidationValues = new HashSet<ValidationValue>();
        }

        public int Id { get; set; }
        public int PresentationTreeId { get; set; }
        public int ValidationTypeId { get; set; }

        public virtual PresentationTree PresentationTree { get; set; } = null!;
        public virtual ValidationType ValidationType { get; set; } = null!;
        public virtual ICollection<ValidationValue> ValidationValues { get; set; }
    }
}

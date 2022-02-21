using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class ValidationValue
    {
        public int Id { get; set; }
        public int ValidationId { get; set; }
        public object Value { get; set; } = null!;

        public virtual Validation Validation { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class ValidationType
    {
        public ValidationType()
        {
            Validations = new HashSet<Validation>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Validation> Validations { get; set; }
    }
}

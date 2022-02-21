using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class PhoneType
    {
        public PhoneType()
        {
            Phones = new HashSet<Phone>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Phone> Phones { get; set; }
    }
}

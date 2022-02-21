using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Phone
    {
        public Phone()
        {
            EntityPhones = new HashSet<EntityPhone>();
        }

        public int Id { get; set; }
        public string Number { get; set; } = null!;
        public int PhoneTypeId { get; set; }

        public virtual PhoneType PhoneType { get; set; } = null!;
        public virtual ICollection<EntityPhone> EntityPhones { get; set; }
    }
}

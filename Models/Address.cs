using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Address
    {
        public Address()
        {
            EntityAddesses = new HashSet<EntityAddess>();
        }

        public int Id { get; set; }
        public int AddressTypeId { get; set; }
        public string Line1 { get; set; } = null!;
        public string? Line2 { get; set; }
        public string? Unit { get; set; }
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zip { get; set; } = null!;

        public virtual AddressType AddressType { get; set; } = null!;
        public virtual ICollection<EntityAddess> EntityAddesses { get; set; }
    }
}

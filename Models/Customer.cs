using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Contracts = new HashSet<Contract>();
            CustomerSubCategories = new HashSet<CustomerSubCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? EntityId { get; set; }

        public virtual Entity? Entity { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<CustomerSubCategory> CustomerSubCategories { get; set; }
    }
}

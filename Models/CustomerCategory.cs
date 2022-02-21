using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class CustomerCategory
    {
        public CustomerCategory()
        {
            CustomerSubCategories = new HashSet<CustomerSubCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<CustomerSubCategory> CustomerSubCategories { get; set; }
    }
}

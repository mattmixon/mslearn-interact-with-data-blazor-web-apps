using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class BillingCategory
    {
        public BillingCategory()
        {
            BillingSubCategories = new HashSet<BillingSubCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<BillingSubCategory> BillingSubCategories { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class BillingSubCategory
    {
        public BillingSubCategory()
        {
            BillingCodePricings = new HashSet<BillingCodePricing>();
            ItemMasters = new HashSet<ItemMaster>();
        }

        public int Id { get; set; }
        public int BillingCategoryId { get; set; }
        public string Name { get; set; } = null!;

        public virtual BillingCategory BillingCategory { get; set; } = null!;
        public virtual ICollection<BillingCodePricing> BillingCodePricings { get; set; }
        public virtual ICollection<ItemMaster> ItemMasters { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class BillingServiceCode
    {
        public BillingServiceCode()
        {
            BillingCodePricings = new HashSet<BillingCodePricing>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<BillingCodePricing> BillingCodePricings { get; set; }
    }
}

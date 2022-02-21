using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class SubContract
    {
        public SubContract()
        {
            BillingCodePricings = new HashSet<BillingCodePricing>();
            ItemMasters = new HashSet<ItemMaster>();
            Orders = new HashSet<Order>();
            Rmas = new HashSet<Rma>();
        }

        public int Id { get; set; }
        public int ContractId { get; set; }
        public DateTime EffectiveOn { get; set; }
        public DateTime? ExpiresOn { get; set; }

        public virtual Contract Contract { get; set; } = null!;
        public virtual ICollection<BillingCodePricing> BillingCodePricings { get; set; }
        public virtual ICollection<ItemMaster> ItemMasters { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Rma> Rmas { get; set; }
    }
}

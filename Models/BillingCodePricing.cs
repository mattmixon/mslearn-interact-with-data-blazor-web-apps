using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class BillingCodePricing
    {
        public int Id { get; set; }
        public int SubContractId { get; set; }
        public int BillingSubCategoryId { get; set; }
        public int ServiceCodeId { get; set; }
        public decimal Amount { get; set; }

        public virtual BillingSubCategory BillingSubCategory { get; set; } = null!;
        public virtual BillingServiceCode ServiceCode { get; set; } = null!;
        public virtual SubContract SubContract { get; set; } = null!;
    }
}

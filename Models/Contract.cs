using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Contract
    {
        public Contract()
        {
            SubContracts = new HashSet<SubContract>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime EffectiveOn { get; set; }
        public DateTime? ExpiresOn { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual ICollection<SubContract> SubContracts { get; set; }
    }
}

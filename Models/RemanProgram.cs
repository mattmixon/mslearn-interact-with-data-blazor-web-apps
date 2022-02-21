using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class RemanProgram
    {
        public int Id { get; set; }
        public int FacilityId { get; set; }
        public int ItemMasterId { get; set; }
        public DateTime EffectiveOn { get; set; }
        public DateTime? ExpiresOn { get; set; }

        public virtual Facility Facility { get; set; } = null!;
        public virtual ItemMaster ItemMaster { get; set; } = null!;
    }
}

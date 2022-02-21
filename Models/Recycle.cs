using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Recycle
    {
        public int Id { get; set; }
        public DateTime RecycledOn { get; set; }
        public int RecycleCategory { get; set; }
        public int Recycled { get; set; }
        public int StyroPalletsStaged { get; set; }
        public int CardboardBalesStaged { get; set; }
        public int PlasticBalesStaged { get; set; }
        public int CardboardGaylordsAvailable { get; set; }
        public int ShredPalletsStaged { get; set; }
        public string RecoveryPalletsStaged { get; set; } = null!;
    }
}

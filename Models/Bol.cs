using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Bol
    {
        public int Id { get; set; }
        public int RmaId { get; set; }
        public DateTime CrossedDock { get; set; }
        public int Pallets { get; set; }
        public int? RetailerId { get; set; }
        public int? CarrierId { get; set; }
        public int BolStatusId { get; set; }
        public DateTime? CompletedOn { get; set; }
        public DateTime? ClientClosed { get; set; }
        public bool IsTruck { get; set; }
        public bool IsLtl { get; set; }
        public int Aging { get; set; }
        public int DaysLeft { get; set; }
        public bool IsSlacompliant { get; set; }

        public virtual BolStatus BolStatus { get; set; } = null!;
        public virtual Carrier? Carrier { get; set; }
        public virtual Retailer? Retailer { get; set; }
        public virtual Rma Rma { get; set; } = null!;
    }
}

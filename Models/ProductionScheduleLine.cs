using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class ProductionScheduleLine
    {
        public int Id { get; set; }
        public int ProductionScheduleId { get; set; }
        public int ProductionLineId { get; set; }
        public decimal Goal { get; set; }
        public int? ProductionGroupId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class PutAwayGrid
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public int LocationId { get; set; }
        public int FacilityId { get; set; }
        public int CustomerId { get; set; }
    }
}

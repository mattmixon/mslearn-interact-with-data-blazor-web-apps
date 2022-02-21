using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Shipping
    {
        public int ShippingD { get; set; }
        public int RmaId { get; set; }
        public int TypeId { get; set; }
        public int CarrierId { get; set; }
        public int? Priority { get; set; }
        public int LocationId { get; set; }
        public int? TrackingNumber { get; set; }
        public decimal? Freight { get; set; }
        public int StatusId { get; set; }
        public DateTime? ShipDate { get; set; }
        public int? CustomerId { get; set; }
    }
}

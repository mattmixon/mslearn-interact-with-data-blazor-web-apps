using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class RmaLineItem
    {
        public int Id { get; set; }
        public int RmaId { get; set; }
        public int ItemMasterId { get; set; }
        public int Quantity { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Price { get; set; }
        public DateTime? PurchasedOn { get; set; }
        public DateTime? Eol { get; set; }
        public string? Description { get; set; }
        public string? DefectComments { get; set; }
        public string? Warranty { get; set; }
        public string? CustomerWarranty { get; set; }
        public string? VendorWarranty { get; set; }
        public double? DiscountRate { get; set; }
        public string? CountryOfOrigin { get; set; }
        public string? ProductManager { get; set; }

        public virtual Rma Rma { get; set; } = null!;
    }
}

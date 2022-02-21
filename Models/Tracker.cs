using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Tracker
    {
        public int Id { get; set; }
        public int Load { get; set; }
        public int LoadTypeId { get; set; }
        public int? Bolid { get; set; }
        public int? InvoiceId { get; set; }
        public bool IsParsed { get; set; }
        public decimal? BillAmount { get; set; }
        public int VendorCentralStatusTransship { get; set; }
        public int VendorCentralStatusInvoice { get; set; }
        public string? Notes { get; set; }
    }
}

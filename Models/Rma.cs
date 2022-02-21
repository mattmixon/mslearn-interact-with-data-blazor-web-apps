using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Rma
    {
        public Rma()
        {
            Bols = new HashSet<Bol>();
            RmaLineItems = new HashSet<RmaLineItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int RmaTypeId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UserId { get; set; }
        public string? CustomerReturnReference { get; set; }
        public string? Comments { get; set; }
        public int? Pallets { get; set; }
        public int? TrailerId { get; set; }
        public int? FacilityId { get; set; }
        public int? SubContractId { get; set; }
        public int? ShipperId { get; set; }

        public virtual Facility? Facility { get; set; }
        public virtual RmaType RmaType { get; set; } = null!;
        public virtual Shipper? Shipper { get; set; }
        public virtual SubContract? SubContract { get; set; }
        public virtual Trailer? Trailer { get; set; }
        public virtual User User { get; set; } = null!;
        public virtual ICollection<Bol> Bols { get; set; }
        public virtual ICollection<RmaLineItem> RmaLineItems { get; set; }
    }
}

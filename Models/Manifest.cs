using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Manifest
    {
        public Manifest()
        {
            ManifestDetails = new HashSet<ManifestDetail>();
        }

        public int Id { get; set; }
        public int SubContractId { get; set; }
        public int ManifestTypeId { get; set; }
        public int? SiteId { get; set; }
        public int? OriginatingLocationId { get; set; }
        public DateTime TransmittedOn { get; set; }
        public string? FileName { get; set; }
        public string Rma { get; set; } = null!;

        public virtual ICollection<ManifestDetail> ManifestDetails { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class ManifestSubCategory
    {
        public ManifestSubCategory()
        {
            ManifestDetails = new HashSet<ManifestDetail>();
        }

        public int Id { get; set; }
        public string? Code { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<ManifestDetail> ManifestDetails { get; set; }
    }
}

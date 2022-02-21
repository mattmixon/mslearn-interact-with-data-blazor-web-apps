using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class ManifestDepartment
    {
        public ManifestDepartment()
        {
            ManifestDetails = new HashSet<ManifestDetail>();
        }

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<ManifestDetail> ManifestDetails { get; set; }
    }
}

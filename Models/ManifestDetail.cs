using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class ManifestDetail
    {
        public int Id { get; set; }
        public int ManifestId { get; set; }
        public string SerialNumber { get; set; } = null!;
        public string CustomerUniqueIdentifier { get; set; } = null!;
        public int? ManifestDepartmentId { get; set; }
        public int? ManifestCategoryId { get; set; }
        public int ManifestSubCategoryId { get; set; }
        public decimal? Price { get; set; }
        public int? ManufacturerId { get; set; }
        public string? ModelName { get; set; }
        public string? Reason { get; set; }

        public virtual Manifest Manifest { get; set; } = null!;
        public virtual ManifestCategory? ManifestCategory { get; set; }
        public virtual ManifestDepartment? ManifestDepartment { get; set; }
        public virtual ManifestSubCategory ManifestSubCategory { get; set; } = null!;
        public virtual Manufacturer? Manufacturer { get; set; }
    }
}

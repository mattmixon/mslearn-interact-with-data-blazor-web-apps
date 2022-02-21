using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class MasterCategory
    {
        public MasterCategory()
        {
            MasterSubCategories = new HashSet<MasterSubCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<MasterSubCategory> MasterSubCategories { get; set; }
    }
}

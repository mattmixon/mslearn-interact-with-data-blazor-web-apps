using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class MasterSubCategory
    {
        public MasterSubCategory()
        {
            ItemMasters = new HashSet<ItemMaster>();
        }

        public int Id { get; set; }
        public int MasterCategoryId { get; set; }
        public string Name { get; set; } = null!;

        public virtual MasterCategory MasterCategory { get; set; } = null!;
        public virtual ICollection<ItemMaster> ItemMasters { get; set; }
    }
}

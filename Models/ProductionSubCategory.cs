using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class ProductionSubCategory
    {
        public ProductionSubCategory()
        {
            ItemMasters = new HashSet<ItemMaster>();
        }

        public int Id { get; set; }
        public int ProductionCategoryId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ProductionCategory ProductionCategory { get; set; } = null!;
        public virtual ICollection<ItemMaster> ItemMasters { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class SalesSubCategory
    {
        public SalesSubCategory()
        {
            ItemMasters = new HashSet<ItemMaster>();
        }

        public int Id { get; set; }
        public int SalesCategoryId { get; set; }
        public int Name { get; set; }

        public virtual SalesCategory SalesCategory { get; set; } = null!;
        public virtual ICollection<ItemMaster> ItemMasters { get; set; }
    }
}

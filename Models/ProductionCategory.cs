using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class ProductionCategory
    {
        public ProductionCategory()
        {
            ProductionSubCategories = new HashSet<ProductionSubCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<ProductionSubCategory> ProductionSubCategories { get; set; }
    }
}

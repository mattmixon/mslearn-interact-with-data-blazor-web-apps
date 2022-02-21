using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class SalesCategory
    {
        public SalesCategory()
        {
            SalesSubCategories = new HashSet<SalesSubCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SalesSubCategory> SalesSubCategories { get; set; }
    }
}

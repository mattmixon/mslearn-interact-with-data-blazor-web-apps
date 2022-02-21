using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class CustomerSubCategory
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int? CustomerCategoryId { get; set; }
        public string Name { get; set; } = null!;

        public virtual Customer Customer { get; set; } = null!;
        public virtual CustomerCategory? CustomerCategory { get; set; }
    }
}

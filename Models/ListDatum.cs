using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class ListDatum
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int TypeId { get; set; }
        public int PayMethodId { get; set; }
        public string Quantity { get; set; } = null!;
        public int Duration { get; set; }
        public int AddressId { get; set; }
    }
}

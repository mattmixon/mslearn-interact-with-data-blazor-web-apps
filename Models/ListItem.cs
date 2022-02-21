using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class ListItem
    {
        public int Id { get; set; }
        public int ListId { get; set; }
        public int SerialId { get; set; }
        public int CategoryId { get; set; }
        public int ConditionId { get; set; }
        public int? TypeId { get; set; }
        public decimal Price { get; set; }
    }
}

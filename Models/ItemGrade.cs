using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class ItemGrade
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Grade { get; set; } = null!;
        public int ParcelTypeId { get; set; }
    }
}

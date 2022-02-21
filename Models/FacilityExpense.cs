using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class FacilityExpense
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int FacilityId { get; set; }
        public decimal ExpensesAllocated { get; set; }
    }
}

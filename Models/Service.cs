using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Service
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int TruckLoad { get; set; }
        public int Ltl { get; set; }
        public int SmallParcel { get; set; }
        public int BolscanType { get; set; }
        public bool IsRmaCloseRequested { get; set; }
    }
}

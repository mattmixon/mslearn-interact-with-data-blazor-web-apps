using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Observation
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public string SerialNumber { get; set; } = null!;
        public string? DataTimeStamp { get; set; }
        public int ObservationTypeId { get; set; }
        public int ObservationCodeId { get; set; }
        public string? ObservationNotes { get; set; }

        public virtual ObservationCode ObservationCode { get; set; } = null!;
        public virtual ObservationType ObservationType { get; set; } = null!;
        public virtual Serial SerialNumberNavigation { get; set; } = null!;
    }
}

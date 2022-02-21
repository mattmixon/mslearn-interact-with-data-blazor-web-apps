using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Session
    {
        public Session()
        {
            Telemetries = new HashSet<Telemetry>();
        }

        public int Id { get; set; }
        public int StationId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ClosedOn { get; set; }

        public virtual Station Station { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual ICollection<Telemetry> Telemetries { get; set; }
    }
}

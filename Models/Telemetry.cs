using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Telemetry
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int SerialId { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public string Field { get; set; } = null!;
        public object? Value { get; set; }

        public virtual Serial Serial { get; set; } = null!;
        public virtual Session Session { get; set; } = null!;
    }
}

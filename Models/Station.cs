using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Station
    {
        public Station()
        {
            Sessions = new HashSet<Session>();
        }

        public int Id { get; set; }
        public int LineId { get; set; }
        public int RemanFunctionId { get; set; }
        public bool IsEnabled { get; set; }

        public virtual Line Line { get; set; } = null!;
        public virtual RemanFunction RemanFunction { get; set; } = null!;
        public virtual ICollection<Session> Sessions { get; set; }
    }
}

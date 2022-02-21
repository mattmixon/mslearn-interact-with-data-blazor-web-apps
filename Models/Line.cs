using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Line
    {
        public Line()
        {
            Stations = new HashSet<Station>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FacilityId { get; set; }

        public virtual Facility Facility { get; set; } = null!;
        public virtual ICollection<Station> Stations { get; set; }
    }
}

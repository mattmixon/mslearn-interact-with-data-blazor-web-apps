using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class BoxType
    {
        public BoxType()
        {
            Serials = new HashSet<Serial>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Serial> Serials { get; set; }
    }
}

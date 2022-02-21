using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Facility
    {
        public Facility()
        {
            Lines = new HashSet<Line>();
            RemanPrograms = new HashSet<RemanProgram>();
            Rmas = new HashSet<Rma>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? EntityId { get; set; }

        public virtual Entity? Entity { get; set; }
        public virtual ICollection<Line> Lines { get; set; }
        public virtual ICollection<RemanProgram> RemanPrograms { get; set; }
        public virtual ICollection<Rma> Rmas { get; set; }
    }
}

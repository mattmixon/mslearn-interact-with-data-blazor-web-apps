using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class TrailerCurrent
    {
        public int Id { get; set; }
        public int TrailerId { get; set; }
        public int TrailerLocationId { get; set; }
        public int TrailerStatusId { get; set; }
        public int TrailerContentId { get; set; }
        public DateTime StatusDate { get; set; }
        public int UserId { get; set; }
        public string? Comments { get; set; }

        public virtual Trailer Trailer { get; set; } = null!;
        public virtual TrailerContent TrailerContent { get; set; } = null!;
        public virtual TrailerLocation TrailerLocation { get; set; } = null!;
        public virtual TrailerStatus TrailerStatus { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}

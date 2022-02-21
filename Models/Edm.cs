using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Edm
    {
        public int Id { get; set; }
        public int DocumentTypeId { get; set; }
        public int FileTypeId { get; set; }
        public int PlatformId { get; set; }
        public int DbId { get; set; }
        public string Path { get; set; } = null!;
    }
}

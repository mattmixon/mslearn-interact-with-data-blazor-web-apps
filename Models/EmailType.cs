using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class EmailType
    {
        public EmailType()
        {
            Emails = new HashSet<Email>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Email> Emails { get; set; }
    }
}

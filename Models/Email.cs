using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Email
    {
        public Email()
        {
            EntityEmails = new HashSet<EntityEmail>();
        }

        public int Id { get; set; }
        public string Address { get; set; } = null!;
        public int EmailType { get; set; }

        public virtual EmailType EmailTypeNavigation { get; set; } = null!;
        public virtual ICollection<EntityEmail> EntityEmails { get; set; }
    }
}

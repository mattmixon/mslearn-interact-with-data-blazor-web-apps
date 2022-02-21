using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class User
    {
        public User()
        {
            Rmas = new HashSet<Rma>();
            SerialLocationChains = new HashSet<SerialLocationChain>();
            Sessions = new HashSet<Session>();
            TrailerCurrents = new HashSet<TrailerCurrent>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int? EntityId { get; set; }
        public bool IsTerminated { get; set; }

        public virtual Entity? Entity { get; set; }
        public virtual ICollection<Rma> Rmas { get; set; }
        public virtual ICollection<SerialLocationChain> SerialLocationChains { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<TrailerCurrent> TrailerCurrents { get; set; }
    }
}

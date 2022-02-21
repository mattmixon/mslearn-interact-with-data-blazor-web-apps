using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class EntityType
    {
        public EntityType()
        {
            Entities = new HashSet<Entity>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Entity> Entities { get; set; }
    }
}

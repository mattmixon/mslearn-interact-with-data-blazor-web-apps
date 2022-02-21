using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Entity
    {
        public Entity()
        {
            Customers = new HashSet<Customer>();
            EntityAddesses = new HashSet<EntityAddess>();
            EntityEmails = new HashSet<EntityEmail>();
            EntityPhones = new HashSet<EntityPhone>();
            Facilities = new HashSet<Facility>();
            Factories = new HashSet<Factory>();
            ItemMasters = new HashSet<ItemMaster>();
            Manufacturers = new HashSet<Manufacturer>();
            OriginatingLocations = new HashSet<OriginatingLocation>();
            Retailers = new HashSet<Retailer>();
            Shippers = new HashSet<Shipper>();
            Sites = new HashSet<Site>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public int EntityTypeId { get; set; }
        public string? Business { get; set; }
        public string? First { get; set; }
        public string? Last { get; set; }
        public string? Middle { get; set; }
        public string? Suffix { get; set; }
        public string? Prefix { get; set; }

        public virtual EntityType EntityType { get; set; } = null!;
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<EntityAddess> EntityAddesses { get; set; }
        public virtual ICollection<EntityEmail> EntityEmails { get; set; }
        public virtual ICollection<EntityPhone> EntityPhones { get; set; }
        public virtual ICollection<Facility> Facilities { get; set; }
        public virtual ICollection<Factory> Factories { get; set; }
        public virtual ICollection<ItemMaster> ItemMasters { get; set; }
        public virtual ICollection<Manufacturer> Manufacturers { get; set; }
        public virtual ICollection<OriginatingLocation> OriginatingLocations { get; set; }
        public virtual ICollection<Retailer> Retailers { get; set; }
        public virtual ICollection<Shipper> Shippers { get; set; }
        public virtual ICollection<Site> Sites { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}

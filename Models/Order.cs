using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Order
    {
        public Order()
        {
            Items = new HashSet<Item>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public int? LocationId { get; set; }
        public int? SubContractId { get; set; }
        public int? StatusId { get; set; }
        public byte? Priority { get; set; }

        public virtual Location? Location { get; set; }
        public virtual OrderStatus? Status { get; set; }
        public virtual SubContract? SubContract { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}

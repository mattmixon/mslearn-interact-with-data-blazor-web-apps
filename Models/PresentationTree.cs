using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class PresentationTree
    {
        public PresentationTree()
        {
            Conditions = new HashSet<Condition>();
            PresentationTreeDefaults = new HashSet<PresentationTreeDefault>();
            Validations = new HashSet<Validation>();
        }

        public int Id { get; set; }
        public int RemanFunctionId { get; set; }
        public int UiNodeTypeId { get; set; }
        public string DisplayPrompt { get; set; } = null!;
        public string DbFieldSchemaName { get; set; } = null!;
        public int DataTypeId { get; set; }
        public int TelemetryTypeId { get; set; }
        public bool IsCurrent { get; set; }
        public int SequenceNumber { get; set; }
        public int? ParentNode { get; set; }

        public virtual DataType DataType { get; set; } = null!;
        public virtual RemanFunction RemanFunction { get; set; } = null!;
        public virtual TelemetryType TelemetryType { get; set; } = null!;
        public virtual UiNodeType UiNodeType { get; set; } = null!;
        public virtual ICollection<Condition> Conditions { get; set; }
        public virtual ICollection<PresentationTreeDefault> PresentationTreeDefaults { get; set; }
        public virtual ICollection<Validation> Validations { get; set; }
    }
}

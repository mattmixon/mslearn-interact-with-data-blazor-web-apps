using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class Serial
    {
        public Serial()
        {
            ItemSerials = new HashSet<ItemSerial>();
            Observations = new HashSet<Observation>();
            SerialLocationChains = new HashSet<SerialLocationChain>();
            Telemetries = new HashSet<Telemetry>();
        }

        public int Id { get; set; }
        public int? ManifestId { get; set; }
        public string SerialNumber { get; set; } = null!;
        public int? ModelId { get; set; }
        public int? ReceiptBoxTypeId { get; set; }
        public int? ReceiptBoxConditionId { get; set; }
        public DateTime? ReceivedOn { get; set; }
        public string ManufacturersSerial { get; set; } = null!;
        public bool IsSafety { get; set; }
        public int? SafetyHazardId { get; set; }
        public int CurrentLocationId { get; set; }
        public int? CurrentInventoryStage { get; set; }

        public virtual InventoryStage? CurrentInventoryStageNavigation { get; set; }
        public virtual Location CurrentLocation { get; set; } = null!;
        public virtual BoxCondition? ReceiptBoxCondition { get; set; }
        public virtual BoxType? ReceiptBoxType { get; set; }
        public virtual Hazard? SafetyHazard { get; set; }
        public virtual ICollection<ItemSerial> ItemSerials { get; set; }
        public virtual ICollection<Observation> Observations { get; set; }
        public virtual ICollection<SerialLocationChain> SerialLocationChains { get; set; }
        public virtual ICollection<Telemetry> Telemetries { get; set; }
    }
}

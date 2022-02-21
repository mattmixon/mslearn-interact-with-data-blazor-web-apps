using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class ItemMaster
    {
        public ItemMaster()
        {
            ItemAlts = new HashSet<ItemAlt>();
            Items = new HashSet<Item>();
            RemanPrograms = new HashSet<RemanProgram>();
        }

        public int Id { get; set; }
        public int SubContractId { get; set; }
        public int UnitTypeId { get; set; }
        public int? MasterSubCategoryId { get; set; }
        public string? ImageLink { get; set; }
        public string ModelNumber { get; set; } = null!;
        public string? CustomerUniqueIdentifier { get; set; }
        public string? Upc { get; set; }
        public int? ManufacturerId { get; set; }
        public int? BrandId { get; set; }
        public bool HasKit { get; set; }
        public decimal? ArcCost { get; set; }
        public decimal? CustomerCost { get; set; }
        public double? UnitLength { get; set; }
        public double? UnitWidth { get; set; }
        public double? UnitHeight { get; set; }
        public double? UnitWeight { get; set; }
        public double? ShipLength { get; set; }
        public double? ShipWidth { get; set; }
        public double? ShipHeight { get; set; }
        public double? ShipWeight { get; set; }
        public string? UnitColor { get; set; }
        public string? UnitDescription { get; set; }
        public int? CountryId { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? MarketStatusId { get; set; }
        public bool IsConnected { get; set; }
        public bool IsWiFi { get; set; }
        public bool IsBluetooth { get; set; }
        public int? AutomatedAssistantTypeId { get; set; }
        public bool IsCdp { get; set; }
        public int? FuelPowerTypeId { get; set; }
        public double? WattsExpected { get; set; }
        public double? VoltsExpected { get; set; }
        public double? AmpsExpected { get; set; }
        public double? PsiExpected { get; set; }
        public double? PowerOutputExpected { get; set; }
        public double? GsllonsExpected { get; set; }
        public double? VolumeExpected { get; set; }
        public double? BtuCoolExpected { get; set; }
        public double? BtuHeatExpected { get; set; }
        public bool IsAutoScrap { get; set; }
        public bool IsRtv { get; set; }
        public int? RtvContactId { get; set; }
        public int? SalesChannelId { get; set; }
        public int? CustomerSubCategoryId { get; set; }
        public int? RefurbManufacturerId { get; set; }
        public int? RefurbBrandId { get; set; }
        public string? RefurbColor { get; set; }
        public bool? IsRefurbConnected { get; set; }
        public bool? IsRefurbWifi { get; set; }
        public bool? IsRefurbBluetooth { get; set; }
        public bool? IsRefurbCdp { get; set; }
        public int? SalesSubCategoryId { get; set; }
        public int BuildStatusId { get; set; }
        public int? BillingSubCategoryId { get; set; }
        public int? ProductionSubCategoryId { get; set; }

        public virtual AutomatedAssistantType? AutomatedAssistantType { get; set; }
        public virtual BillingSubCategory? BillingSubCategory { get; set; }
        public virtual Brand? Brand { get; set; }
        public virtual BuildStatus BuildStatus { get; set; } = null!;
        public virtual Country? Country { get; set; }
        public virtual FuelPowerType? FuelPowerType { get; set; }
        public virtual Manufacturer? Manufacturer { get; set; }
        public virtual ItemMarketStatus? MarketStatus { get; set; }
        public virtual MasterSubCategory? MasterSubCategory { get; set; }
        public virtual ProductionSubCategory? ProductionSubCategory { get; set; }
        public virtual Entity? RtvContact { get; set; }
        public virtual SalesChannel? SalesChannel { get; set; }
        public virtual SalesSubCategory? SalesSubCategory { get; set; }
        public virtual SubContract SubContract { get; set; } = null!;
        public virtual UnitType UnitType { get; set; } = null!;
        public virtual ICollection<ItemAlt> ItemAlts { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<RemanProgram> RemanPrograms { get; set; }
    }
}

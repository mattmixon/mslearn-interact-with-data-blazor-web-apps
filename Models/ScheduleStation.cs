using System;
using System.Collections.Generic;

namespace ArcWeb.Shared.Models
{
    public partial class ScheduleStation
    {
        public int Id { get; set; }
        public int ReceivingScheduleId { get; set; }
        public int ReceivingStationId { get; set; }
        public int ReceivedById { get; set; }
    }
}

using System;

namespace ReceiveMonitoringDataServer.Models
{
    public class MonitorDataQueryConditionsModel : EntityBase<int>
    {
        public DateTime Time { get; set; }
        public int PointsNumberId { get; set; }
        public virtual MonitoringPointsNumber PointsNumber { get; set; }
    }
}

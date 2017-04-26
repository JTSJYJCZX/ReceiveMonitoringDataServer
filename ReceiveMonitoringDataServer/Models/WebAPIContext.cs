using System.Data.Entity;

namespace ReceiveMonitoringDataServer.Models
{
    public class WebAPIContext: DbContext
    {
        public WebAPIContext() : base("BHMSDB") { }

        public DbSet<MonitoringPointsNumber> MonitoringPointsNumbers { get; set; }

        public DbSet<Original_SteelArchStrainTable> Original_SteelArchStrains { get; set; }//钢拱肋应变
        public DbSet<Original_SteelLatticeStrainTable> Original_SteelLatticeStrains { get; set; }//钢格构应变
        public DbSet<Original_ConcreteStrainTable> Original_ConcreteStrains { get; set; }//混凝土应变
        public DbSet<Original_DisplacementTable> Original_Displacements { get; set; }//位移
        public DbSet<Original_CableForceTable> Original_CableForces { get; set; }//索力
        public DbSet<Original_TemperatureTable> Original_Temperatures { get; set; }//温度 
        public DbSet<Original_HumidityTable> Original_Humiditys { get; set; }//湿度 
        public DbSet<Original_WindLoadTable> Original_WindLoads { get; set; }//风载

    }
}
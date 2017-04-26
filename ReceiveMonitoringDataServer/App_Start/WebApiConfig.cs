using Microsoft.OData.Edm;
using ReceiveMonitoringDataServer.Models;
using System.Web.Http;
using System.Web.OData.Batch;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace ReceiveMonitoringDataServer
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //// Web API 配置和服务

            //// Web API 路由
            //config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
            config.MapODataServiceRoute("odata", "odata", GetEdmModel(), new DefaultODataBatchHandler(GlobalConfiguration.DefaultServer));
            config.Select().Expand().Filter().OrderBy().MaxTop(null).Count();
            config.EnsureInitialized();
        }
        static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.Namespace = "JTJC";
            builder.ContainerName = "DefaultContainer";
            builder.EntitySet<Original_CableForceTable>("Original_CableForces");
            builder.EntitySet<Original_ConcreteStrainTable>("Original_ConcreteStrains");
            builder.EntitySet<Original_DisplacementTable>("Original_Displacements");
            builder.EntitySet<Original_HumidityTable>("Original_Humiditys");
            builder.EntitySet<Original_SteelArchStrainTable>("Original_SteelArchStrains");
            builder.EntitySet<Original_SteelLatticeStrainTable>("Original_SteelLatticeStrains");
            builder.EntitySet<Original_TemperatureTable>("Original_Temperatures");
            builder.EntitySet<Original_WindLoadTable>("Original_WindLoads");

            var result = builder.GetEdmModel();
            return result;
        }
    }
}

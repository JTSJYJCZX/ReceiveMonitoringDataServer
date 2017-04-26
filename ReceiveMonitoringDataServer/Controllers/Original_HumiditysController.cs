using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData;
using ReceiveMonitoringDataServer.Models;

namespace ReceiveMonitoringDataServer.Controllers
{
    /*
    在为此控制器添加路由之前，WebApiConfig 类可能要求你做出其他更改。请适当地将这些语句合并到 WebApiConfig 类的 Register 方法中。请注意 OData URL 区分大小写。

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using ReceiveMonitoringDataServer.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<StrainTable>("StrainTables");
    builder.EntitySet<MonitoringPointsNumber>("MonitoringPointsNumbers"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class Original_HumiditysController : ODataController
    {
        readonly WebAPIContext db = new WebAPIContext();

        // POST: odata/SteelArchStrainTables
        public async Task<IHttpActionResult> Post(Original_HumidityTable humiditysTable)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Original_Humiditys.Add(humiditysTable);
            await db.SaveChangesAsync();
            return Created(humiditysTable);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}

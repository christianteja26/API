using BSIS.BoarderLogNightMonitoring.Model.Base;
using BSIS.BoarderLogNightMonitoring.Model;
using BSIS.BoarderLogNightMonitoring.Data.Context;
using BSIS.BoarderLogNightMonitoring.Service.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading;
using System.Threading.Tasks;
using BSIS.BoarderLogNightMonitoring.Data.Repositories;
using BSIS.BoarderLogNightMonitoring.Data.Infrastructure;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BSIS.BoarderLogNightMonitoring.API.Controllers
{
    public class LogNightController : ApiController
    {
        #region "deklarasi variable"
        //DB SET
        private BoarderContext db = new BoarderContext();
        //Service -> SP
        private readonly ILogNightService LogNightService;
        //Constructor Service
        public LogNightController()
        {
            this.LogNightService = new LogNightService();
        }
        #endregion

        [Route("api/lognight/lognightdata")]
        [HttpPost]
        public async Task<IHttpActionResult> GetLogNightData()
        {
            //Array Object
            //string body = await Request.Content.ReadAsStringAsync();
            //List<LogNightData> logNightList = new List<LogNightData>();
            //logNightList = JsonConvert.DeserializeObject<List<LogNightData>>(body);
            //var Result = await LogNightService.PostLogNightList(logNightList);
            //return Json(Result);

            string body = await Request.Content.ReadAsStringAsync();
            LogNightData logNightData = JsonConvert.DeserializeObject<LogNightData>(body);
            var Result = await LogNightService.PostLogNightList(logNightData.Data);
            BaseResponse br = new BaseResponse();
            if (Result.Status == true)
            {
                br.success = true;
            }
            else
                br.success = false;
            return Json(br);
        }
    }
}

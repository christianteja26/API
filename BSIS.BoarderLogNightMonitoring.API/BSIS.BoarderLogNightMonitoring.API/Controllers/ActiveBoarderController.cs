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
using System.Web;

namespace BSIS.BoarderLogNightMonitoring.API.Controllers
{
    public class ActiveBoarderController : ApiController
    {
        #region "deklarasi variable"
        //DB SET
        private BoarderContext db = new BoarderContext();
        //Service -> SP
        private readonly IActiveBoarderService ActiveBoarderService;
        private readonly IActiveBoarderCountService ActiveBoarderCountService;
        private readonly ICheckOutBoarderService CheckOutBoarderService;
        //Constructor Service
        public ActiveBoarderController()
        {
            this.ActiveBoarderService = new ActiveBoarderService();
            this.ActiveBoarderCountService = new ActiveBoarderCountService();
            this.CheckOutBoarderService = new CheckOutBoarderService();
        }
        #endregion

        [Route("api/activeboarder/activeboarderdata")]
        [HttpPost]
        public async Task<IHttpActionResult> GetActiveBoarderData()
        {
            string body = await Request.Content.ReadAsStringAsync();
            SyncBatchSetting syncBatchSetting = JsonConvert.DeserializeObject<SyncBatchSetting>(body);
            HttpContext.Current.Server.ScriptTimeout = 600;
            var Result = await ActiveBoarderService.GetActiveBoarderList(syncBatchSetting);
            return Json(Result);
        }

        [Route("api/activeboarder/activeboardercount")]
        [HttpPost]
        public async Task<IHttpActionResult> GetActiveBoarderCount()
        {
            string body = await Request.Content.ReadAsStringAsync();
            SyncCountSetting syncSetting = JsonConvert.DeserializeObject<SyncCountSetting>(body);
            syncSetting.LastSyncDate = (syncSetting.LastSyncDate == null ? syncSetting.LastSyncDate = "" : syncSetting.LastSyncDate);
            var Result = await ActiveBoarderCountService.GetActiveBoarderListCount(syncSetting.LastSyncDate);
            return Json(Result);
        }

        [Route("api/activeboarder/boardercheckoutdata")]
        [HttpPost]
        public async Task<IHttpActionResult> GetBoarderCheckOutData()
        {
            string body = await Request.Content.ReadAsStringAsync();
            SyncCountSetting syncSetting = JsonConvert.DeserializeObject<SyncCountSetting>(body);
            syncSetting.LastSyncDate = (syncSetting.LastSyncDate == null ? syncSetting.LastSyncDate = "" : syncSetting.LastSyncDate);
            var Result = await CheckOutBoarderService.GetCheckOutBoarderList(syncSetting.LastSyncDate);
            return Json(Result);
        }
    }
}

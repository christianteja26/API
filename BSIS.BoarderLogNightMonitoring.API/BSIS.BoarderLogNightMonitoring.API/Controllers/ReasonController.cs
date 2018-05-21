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

namespace BSIS.BoarderLogNightMonitoring.API.Controllers
{
    public class ReasonController : ApiController
    {
        #region "deklarasi variable"
        //DB SET
        private BoarderContext db = new BoarderContext();
        //Service -> SP
        private readonly IReasonService ReasonService;
        //Constructor Service
        public ReasonController()
        {
            this.ReasonService = new ReasonService();
            //var reasonList = ReasonService.GetReasonList();
            //202.58.181.203/BoarderLogNightMonitoring/api
        }
        #endregion

        [Route("api/reason/reasondata")]
        [HttpGet]
        public async Task<IHttpActionResult> GetReasonData()
        {
            var Result = await ReasonService.GetReasonList(1);
            return Json(Result);
        }

        public IHttpActionResult PostTest()
        {
            return Unauthorized();
        }

        public IHttpActionResult PostByID(int id)
        {
            return Ok(id);
        }

        public IHttpActionResult PutTest()
        {
            return InternalServerError();
        }
    }
}

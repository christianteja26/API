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

namespace BSIS.BoarderLogNightMonitoring.API.Controllers
{
    public class ConfigurationController : ApiController
    {
        #region "deklarasi variable"
        //DB SET
        private BoarderContext db = new BoarderContext();
        //Service -> SP
        private readonly IConfigurationService ConfigurationService;
        //Constructor Service
        public ConfigurationController()
        {
            this.ConfigurationService = new ConfigurationService();
            //var ConfigurationList = ConfigurationService.GetConfigurationList();
            //202.58.181.203/BoarderLogNightMonitoring/api
        }
        #endregion

        [Route("api/configuration/login")]
        [HttpGet]
        public async Task<IHttpActionResult> GetLogin()
        {
            //string body = await Request.Content.ReadAsStringAsync();
            //Login login = JsonConvert.DeserializeObject<Login>(body);
            var Result = await ConfigurationService.GetConfigurationByID(37);
            return Json(Result);
        }
    }
}

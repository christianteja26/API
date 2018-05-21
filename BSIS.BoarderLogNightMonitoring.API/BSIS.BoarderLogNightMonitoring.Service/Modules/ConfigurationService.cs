using BSIS.BoarderLogNightMonitoring.Data.Infrastructure;
using BSIS.BoarderLogNightMonitoring.Data.Repositories;
using BSIS.BoarderLogNightMonitoring.Model;
using BSIS.BoarderLogNightMonitoring.Model.Base;
using BSIS.BoarderLogNightMonitoring.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BSIS.BoarderLogNightMonitoring.Service.Modules
{
    public interface IConfigurationService
    {
        Task<BaseResponse> GetConfigurationByID(Int16 ConfigID);
    }
    public class ConfigurationService : IConfigurationService
    {
        private readonly IConfigurationRepository ConfigurationRepository;

        public ConfigurationService(IConfigurationRepository ConfigurationRepository)
        {
            this.ConfigurationRepository = ConfigurationRepository;
        }

        public ConfigurationService()
        {
            this.ConfigurationRepository = new ConfigurationRepository();
        }

        public async Task<BaseResponse> GetConfigurationByID(Int16 ConfigID)
        {
            EnumerableResponse<Configuration> r = new EnumerableResponse<Configuration>();
            var Param = new[] { new SqlParameter("@ConfigId", ConfigID) };
            r.configs = await ConfigurationRepository.ExecSPToListAsync("EXEC GetConfigurationByConfigId @ConfigId",Param);
            r.success = true;
            //string[] key = Validate.FirstOrDefault().Value.Split(';');
            return r;
        }
    }
}
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
    public interface ILogNightService
    {
        Task<ExecuteResult> PostLogNightList(IList<LogNight> logNightList);
    }
    public class LogNightService : ILogNightService
    {
        private readonly ILogNightRepository LogNightRepository;

        public LogNightService(ILogNightRepository LogNightRepository)
        {
            this.LogNightRepository = LogNightRepository;
        }

        public LogNightService()
        {
            this.LogNightRepository = new LogNightRepository();
        }

        public async Task<ExecuteResult> PostLogNightList(IList<LogNight> logNightList)
        {
            ExecuteResult ReturnValue = new ExecuteResult();
            List<StoredProcedure> Data = new List<StoredProcedure>();
            ModelSQLParamService<LogNight> Param = new ModelSQLParamService<LogNight>();
            StoredProcedure SP;

            if (logNightList != null)
            {
                foreach (var item in logNightList)
                {
                    SP = Param.ConvertInSingleLineParam(item, ParameterType.ExcludeNull);
                    Data.Add(new StoredProcedure
                    {
                        SPName = "BSQ_PostLogNightMonitoring " + SP.SQLParamString
                    });
                }
            }

            ReturnValue = await LogNightRepository.ExecMultipleSPWithTransaction(Data);
            return ReturnValue;
        }
    }
}
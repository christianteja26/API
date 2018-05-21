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
    public interface IReasonService
    {
        Task<BaseResponse> GetReasonList(int ReasonID);
    }
    public class ReasonService : IReasonService
    {
        private readonly IReasonRepository ReasonRepository;

        public ReasonService(IReasonRepository ReasonRepository)
        {
            this.ReasonRepository = ReasonRepository;
        }

        public ReasonService()
        {
            this.ReasonRepository = new ReasonRepository();
        }

        public async Task<BaseResponse> GetReasonList(int ReasonID)
        {
            EnumerableResponse<Reason> r = new EnumerableResponse<Reason>();
            var Param = new[] { new SqlParameter("@ReasonID", ReasonID) };
            r.reasons = await ReasonRepository.ExecSPToListAsync("EXEC BSQ_GetBoarderReasonList @ReasonID",Param);
            r.success = true;
            return r;
        }
    }
}
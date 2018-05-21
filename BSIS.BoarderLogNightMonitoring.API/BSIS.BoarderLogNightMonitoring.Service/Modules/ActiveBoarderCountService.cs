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
using System.IO;

namespace BSIS.BoarderLogNightMonitoring.Service.Modules
{
    public interface IActiveBoarderCountService
    {
        Task<BaseResponse> GetActiveBoarderListCount(string lastSyncDate);
    }
    public class ActiveBoarderCountService : IActiveBoarderCountService
    {
        private readonly IActiveBoarderCountRepository ActiveBoarderCountRepository;

        public ActiveBoarderCountService(IActiveBoarderCountRepository ActiveBoarderCountRepository)
        {
            this.ActiveBoarderCountRepository = ActiveBoarderCountRepository;
        }

        public ActiveBoarderCountService()
        {
            this.ActiveBoarderCountRepository = new ActiveBoarderCountRepository();
        }

        public async Task<BaseResponse> GetActiveBoarderListCount(string lastSyncDate)
        {
            //string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            EnumerableResponse<ActiveBoarderCount> r = new EnumerableResponse<ActiveBoarderCount>();
            var Param = new[] { new SqlParameter("@LastSyncDate", lastSyncDate) };
            r.activeBoarderCounts = await ActiveBoarderCountRepository.ExecSPToListAsync("EXEC BSQ_GetBoarderActiveListCount @LastSyncDate", Param);
            r.success = true;
            return r;
        }
    }
}

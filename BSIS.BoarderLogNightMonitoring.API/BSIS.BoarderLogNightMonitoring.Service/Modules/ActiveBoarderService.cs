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
    public interface IActiveBoarderService
    {
        Task<BaseResponse> GetActiveBoarderList(SyncBatchSetting syncBatchSetting);
    }
    public class ActiveBoarderService : IActiveBoarderService
    {
        private readonly IActiveBoarderRepository ActiveBoarderRepository;

        public ActiveBoarderService(IActiveBoarderRepository ActiveBoarderRepository)
        {
            this.ActiveBoarderRepository = ActiveBoarderRepository;
        }

        public ActiveBoarderService()
        {
            this.ActiveBoarderRepository = new ActiveBoarderRepository();
        }

        public async Task<BaseResponse> GetActiveBoarderList(SyncBatchSetting syncBatchSetting)
        {
            EnumerableResponse<ActiveBoarder> r = new EnumerableResponse<ActiveBoarder>();
            var Param = new[] { new SqlParameter("@Batch", syncBatchSetting.Batch),
                                new SqlParameter("@RowPerBatch", syncBatchSetting.RowPerBatch)};
            r.activeBoarders = await ActiveBoarderRepository.ExecSPToListAsync("EXEC BSQ_GetBoarderActiveList @Batch, @RowPerBatch", Param);
            r.success = true;
            //byte[] data = r.activeBoarders.First().Photo;
            //MemoryStream ms = new MemoryStream(data);
            return r;
        }
    }
}

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
    public interface ICheckOutBoarderService
    {
        Task<BaseResponse> GetCheckOutBoarderList(string lastSyncDate);
    }
    public class CheckOutBoarderService : ICheckOutBoarderService
    {
        private readonly ICheckOutBoarderRepository CheckOutBoarderRepository;

        public CheckOutBoarderService(ICheckOutBoarderRepository CheckOutBoarderRepository)
        {
            this.CheckOutBoarderRepository = CheckOutBoarderRepository;
        }

        public CheckOutBoarderService()
        {
            this.CheckOutBoarderRepository = new CheckOutBoarderRepository();
        }

        public async Task<BaseResponse> GetCheckOutBoarderList(string lastSyncDate)
        {
            EnumerableResponse<CheckOutBoarder> r = new EnumerableResponse<CheckOutBoarder>();
            var Param = new[] { new SqlParameter("@LastSyncDate", lastSyncDate) };
            r.checkOutBoarders = await CheckOutBoarderRepository.ExecSPToListAsync("EXEC BSQ_GetBoarderCheckOutForSync @LastSyncDate", Param);
            r.success = true;
            return r;
        }
    }
}

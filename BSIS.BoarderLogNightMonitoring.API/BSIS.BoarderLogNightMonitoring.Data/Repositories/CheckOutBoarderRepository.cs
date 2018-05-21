using BSIS.BoarderLogNightMonitoring.Data.Infrastructure;
using BSIS.BoarderLogNightMonitoring.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BSIS.BoarderLogNightMonitoring.Data.Repositories
{
    public class CheckOutBoarderRepository : RepositoryBase<CheckOutBoarder>, ICheckOutBoarderRepository
    {
        public CheckOutBoarderRepository(IDbFactory DbFactory) : base(DbFactory) { }
        public CheckOutBoarderRepository() : base() { }
    }

    public interface ICheckOutBoarderRepository : IRepository<CheckOutBoarder>
    {

    }
}

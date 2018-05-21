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
    public class ActiveBoarderRepository : RepositoryBase<ActiveBoarder>, IActiveBoarderRepository
    {
        public ActiveBoarderRepository(IDbFactory DbFactory) : base(DbFactory) { }
        public ActiveBoarderRepository() : base() { }
    }

    public interface IActiveBoarderRepository : IRepository<ActiveBoarder>
    {

    }
}
